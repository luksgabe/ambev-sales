using Ambev.DeveloperEvaluation.Domain.SeedWork;

namespace Ambev.DeveloperEvaluation.Application.Configuration.Messaging
{
    public abstract class Event : Message, IEvent, IEventHandler
    {
        public DateTime Timestamp { get; private set; }
        protected Event()
        {
            Timestamp = DateTime.Now.ToUniversalTime();
        }

    }
}
