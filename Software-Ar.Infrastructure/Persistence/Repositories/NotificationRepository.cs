using Software_Ar.Core.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Infrastructure.Persistence.Repositories
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
      public async Task<IEnumerable<Notification>> GetAllAsync() 
        {
            return await Notification;
        }
    
      public async Task<Notification> GetByTitleAsync(string title)
        {
            var notification = await GetByTitleAsyncAsync.FirstOrDifUlt(t.t=>title==title);
        }
    }
}
