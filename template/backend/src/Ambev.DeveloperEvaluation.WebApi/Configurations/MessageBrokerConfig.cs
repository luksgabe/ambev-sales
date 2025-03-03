using Ambev.DeveloperEvaluation.Application;
using Ambev.DeveloperEvaluation.Bus;

namespace Ambev.DeveloperEvaluation.WebApi.Configurations
{
    public static class MessageBrokerConfig
    {
        private static ILogger _logger;

        public static void AddMessageBrokerConfig(this WebApplication app)
        {
            _logger = app.Logger;
            try
            {
                _logger.LogInformation("Iniciando serviço de mapeamento de filas");
                var currentAssembly = typeof(ApplicationLayer).Assembly;
                var eventHandlersTypes = currentAssembly.GetTypes().Where(t =>
                    t.FullName.StartsWith("Ambev.DeveloperEvaluation.Application") &&
                    t.FullName.EndsWith("EventHandler"));

                _logger.LogInformation("Filas"+ string.Join(',', eventHandlersTypes.Select(s => s.FullName)));

                foreach (var eventHandlerType in eventHandlersTypes)
                {
                    string domain = eventHandlerType.FullName.Split('.')[3];
                    if (domain != null)
                    {
                        var eventTypes = currentAssembly.GetTypes().Where(t =>
                            t.FullName.StartsWith($"Ambev.DeveloperEvaluation.Application.{domain}") &&
                            t.FullName.EndsWith("Event"));

                        using (var scope = app.Services.CreateScope())
                        {
                            var serviceProvider = scope.ServiceProvider;
                            var mediatorHandler = serviceProvider.GetRequiredService<IRabbitMQueueBus>();

                            foreach (var eventType in eventTypes)
                            {
                                _logger.LogInformation($"Usando reflexão para chamar método Subscribe com argumentos genéricos. Evento a ser registrado:{eventType.Name}");
                                var method = typeof(IRabbitMQueueBus).GetMethod("Subscribe");
                                var genericMethod = method.MakeGenericMethod(eventType, eventHandlerType);
                                genericMethod.Invoke(mediatorHandler, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("TargetInvocationException: " + ex.Message);

                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                    _logger.LogError("Inner Exception: " + ex.InnerException.Message);
                }
            }
        }
    }
}
