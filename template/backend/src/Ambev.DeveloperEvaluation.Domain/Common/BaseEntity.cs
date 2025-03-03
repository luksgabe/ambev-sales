using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.SeedWork;

namespace Ambev.DeveloperEvaluation.Domain.Common;

public abstract class BaseEntity : IComparable<BaseEntity>
{
    private List<IEvent> _domainEvents;

    public Guid Id { get; set; }

    /// <summary>
    /// Gets the date and time when the user was created.
    /// </summary>
    public abstract DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the user's information.
    /// </summary>
    public abstract DateTime? UpdatedAt { get; set; }
    public Task<IEnumerable<ValidationErrorDetail>> ValidateAsync()
    {
        return Validator.ValidateAsync(this);
    }
    public IReadOnlyCollection<IEvent> DomainEvents => _domainEvents?.AsReadOnly();

    public int CompareTo(BaseEntity? other)
    {
        if (other == null)
        {
            return 1;
        }

        return other!.Id.CompareTo(Id);
    }

    public void AddDomainEvent(IEvent domainEvent)
    {
        _domainEvents = _domainEvents ?? new List<IEvent>();
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent(IEvent domainEvent)
    {
        _domainEvents?.Remove(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents?.Clear();
    }
}
