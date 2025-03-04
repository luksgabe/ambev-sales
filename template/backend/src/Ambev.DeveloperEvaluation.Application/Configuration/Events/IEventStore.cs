using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;

namespace Ambev.DeveloperEvaluation.Application.Configuration.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
