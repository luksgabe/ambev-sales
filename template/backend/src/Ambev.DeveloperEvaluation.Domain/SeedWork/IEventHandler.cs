namespace Ambev.DeveloperEvaluation.Domain.SeedWork
{
    public interface IEventHandler<in TEvent> : IEventHandler
    {
        Task Handle(TEvent @event, CancellationToken cancellationToken);
    }

    public interface IEventHandler
    {

    }
}
