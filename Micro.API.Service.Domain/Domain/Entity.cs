

namespace Micro.API.Service.Domain.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MediatR;
    public abstract class Entity
    {
        Int64 _Id;

        public Int64 Id { get { return _Id; } protected set { _Id = value; } }

        private List<INotification> _domainEvents;
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvents(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvent(INotification eventItem)
        {
            _domainEvents?.Clear();
        }
    }
}
