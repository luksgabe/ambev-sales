using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using System;

namespace Ambev.DeveloperEvaluation.Bus
{
    public interface IRabbitMQueueBus
    {
        Task PublishEvent<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
