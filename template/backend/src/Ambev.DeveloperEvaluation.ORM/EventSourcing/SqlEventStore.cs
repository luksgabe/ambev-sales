using Ambev.DeveloperEvaluation.Application.Configuration.Events;
using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;
using Ambev.DeveloperEvaluation.ORM.Repositories.EventSourcing;
using Newtonsoft.Json;

namespace Ambev.DeveloperEvaluation.ORM.EventSourcing
{
    public class SqlEventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;

        public SqlEventStore(IEventStoreRepository eventStoreRepository)
        {
            _eventStoreRepository = eventStoreRepository;
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new StoredEvent(
                theEvent,
                serializedData);

            _eventStoreRepository.Store(storedEvent);
        }
    }
}
