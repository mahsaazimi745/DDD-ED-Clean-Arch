using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Shared
{
    public class BaseAggregateRoot : BaseEntity
    {
        //private readonly BaseDomainEvent _domainevent;
        //private readonly List<BaseDomainEvent> _domainEvents = new List<BaseDomainEvent>();
        public BaseAggregateRoot(Guid? id = null) : base(id ?? Guid.NewGuid())
        {
        }
        private readonly List<BaseDomainEvent> _domainEvents = new();


        /// دسترسی ReadOnly برای بیرون کلاس
        public IReadOnlyCollection<BaseDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(BaseDomainEvent baseDomain)
        {
            _domainEvents.Add(baseDomain);
        }
        public void RemoveDomainEvent(BaseDomainEvent baseDomain)
        {
            _domainEvents.Remove(baseDomain);
        }
        public void ClearDomainEvents() 
        {
            _domainEvents.Clear();
        }
        // ابزار عمومی برای کار با بک‌فیلدها
        protected void AddChild<T>(ICollection<T> collection, T child)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            collection.Add(child);
        }
        protected void RemoveChild<T>(ICollection<T> collection, T child)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            collection.Remove(child);
        }
    }
}