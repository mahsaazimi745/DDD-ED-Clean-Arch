using Software_Ar.Core.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications
{
    public interface INotificationRepository:IRepository<Notification>
    {
    

        Task<Notification> GetByTitleAsync(string title);
 
    }
}
