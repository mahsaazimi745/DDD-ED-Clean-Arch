using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Shared
{
    public abstract class BaseEntity
    {
        protected BaseEntity(Guid? id = null)
        {
            //Id=Guid.NewGuid();
            //CreationDate =new DateTime();
            Id = id ?? Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid Id { get;  protected set; }
        public DateTime CreationDate { get; }
    }
}
