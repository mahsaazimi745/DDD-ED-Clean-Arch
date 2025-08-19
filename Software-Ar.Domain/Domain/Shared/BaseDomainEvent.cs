using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Shared
{
    public class BaseDomainEvent
    {
        public BaseDomainEvent()
        {
            OccurredOn = DateTime.UtcNow; 
        }

        public DateTime OccurredOn { get; protected set; }

    }
}
