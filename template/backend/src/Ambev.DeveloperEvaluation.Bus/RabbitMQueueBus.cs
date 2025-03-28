﻿using Ambev.DeveloperEvaluation.Application.Configuration.Events;
using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Ambev.DeveloperEvaluation.Bus
{
    public class RabbitMQueueBus : IRabbitMQueueBus
    {
        private readonly ILogger<RabbitMQueueBus> _logger;
        private readonly RabbitMqSetting _setting;
        private readonly IMediator _mediator;
        private readonly Dictionary<string, List<Type>> _handlers;
        private readonly List<Type> _evenTypes;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly IEventStore _eventStore;

        public RabbitMQueueBus(IEventStore eventStore, IMediator mediator, RabbitMqSetting settings, IServiceScopeFactory serviceScopeFactory, ILogger<RabbitMQueueBus> logger)
        {
            _setting = settings;
            _eventStore = eventStore;
            _mediator = mediator;
            _serviceScopeFactory = serviceScopeFactory;
            _handlers = new Dictionary<string, List<Type>>();
            _evenTypes = new List<Type>();
            _logger = logger;
        }

        public async Task PublishEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
            {
                _eventStore?.Save(@event);
            }

            try
            {
                _logger.LogInformation("Tentando se conectar...");
                var factory = new ConnectionFactory()
                {
                    HostName = _setting.Host,
                    UserName = _setting.User,
                    Password = _setting.Password
                };
                using var connection = factory.CreateConnection();
                using var channel = connection.CreateModel();
                var eventName = @event.GetType().Name;
                channel.QueueDeclare(eventName, false, false, false, null);
                var message = JsonConvert.SerializeObject(@event);
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish("", eventName, null, body);

                _logger.LogInformation($"Conectado ao serviço de rabbitMq com conexão: {connection.ClientProvidedName} com estado de conexão aberta definida como: {connection.IsOpen} ");
                _logger.LogInformation($"{eventName}: {message}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Atenção, ocorreu o seguinte erro:{ex.Message} com stack: {ex.StackTrace} e innerException: {ex.InnerException.Message}");
            }

        }

        public void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>
        {
            var eventName = typeof(T).Name;
            var handlerType = typeof(TH);

            if (!_evenTypes.Contains(typeof(T)))
            {
                _evenTypes.Add(typeof(T));
            }

            if (!_handlers.ContainsKey(eventName))
            {
                _handlers.Add(eventName, new List<Type>());
            }

            if (_handlers[eventName].Any(s => s == handlerType))
            {
                _logger.LogError($"Handler Type {handlerType.Name} already is registered for '{eventName}'", nameof(handlerType));
                throw new ArgumentException($"Handler Type {handlerType.Name} already is registered for '{eventName}'", nameof(handlerType));
            }

            _handlers[eventName].Add(handlerType);

            StartBasicConsumer<T>();

        }

        private void StartBasicConsumer<T>() where T : Event
        {
            var factory = new ConnectionFactory()
            {
                HostName = _setting.Host,
                UserName = _setting.User,
                Password = _setting.Password,
                DispatchConsumersAsync = true
            };

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            var eventName = typeof(T).Name;
            channel.QueueDeclare(eventName, false, false, false, null);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.Received += Consumer_Received;

            channel.BasicConsume(eventName, false, consumer);
        }

        private async Task Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var eventName = e.RoutingKey;
            var message = Encoding.UTF8.GetString(e.Body.Span);

            try
            {
                await ProcessEvent(eventName, message).ConfigureAwait(false);
                ((AsyncDefaultBasicConsumer)sender).Model.BasicAck(deliveryTag: e.DeliveryTag, multiple: false);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Something went wrong with Consumer_Received!");
            }
        }

        private async Task ProcessEvent(string eventName, string message)
        {
            if (_handlers.ContainsKey(eventName))
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var subscriptions = _handlers[eventName];
                    foreach (var subscription in subscriptions)
                    {
                        var handler = scope.ServiceProvider.GetService(subscription);

                        if (handler == null)
                        {
                            continue;
                        }

                        CancellationTokenSource source = new CancellationTokenSource();
                        CancellationToken token = source.Token;

                        var eventType = _evenTypes.SingleOrDefault(t => t.Name == eventName);
                        var @event = JsonConvert.DeserializeObject(message, eventType);

                        var concreteType = typeof(IEventHandler<>).MakeGenericType(eventType);

                        await (Task)concreteType.GetMethod("Handle").Invoke(handler, new object[] { @event, token });

                    }
                }
            }
        }
    }
}
