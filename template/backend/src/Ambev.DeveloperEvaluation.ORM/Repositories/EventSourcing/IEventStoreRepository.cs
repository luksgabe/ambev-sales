using Ambev.DeveloperEvaluation.Application.Configuration.Events;

namespace Ambev.DeveloperEvaluation.ORM.Repositories.EventSourcing
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        Task<IList<StoredEvent>> All(Guid aggregateId);
    }
}
