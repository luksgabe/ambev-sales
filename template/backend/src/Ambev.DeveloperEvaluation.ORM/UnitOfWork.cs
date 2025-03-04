using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;
using Ambev.DeveloperEvaluation.Bus;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ambev.DeveloperEvaluation.ORM
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DefaultContext _context;
        private readonly IRabbitMQueueBus _bus;

        public UnitOfWork(DefaultContext context, IRabbitMQueueBus bus)
        {
            _context = context;
            _bus = bus;
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _bus.PublishDomainEvents(_context).ConfigureAwait(false);
            return await this._context.SaveChangesAsync(cancellationToken);
        }
    }

    public static class MediatorExtension
    {
        public static async Task PublishDomainEvents<T>(this IRabbitMQueueBus bus, T ctx) where T : DbContext
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<BaseEntity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            var tasks = domainEvents
                .Select(async (domainEvent) => {
                    await bus.PublishEvent((Event)domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}
