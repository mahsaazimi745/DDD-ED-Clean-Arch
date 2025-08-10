using Microsoft.EntityFrameworkCore;
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
        private readonly AppDbContext _context;
        public NotificationRepository(AppDbContext context):base(context)
        {
            _context = context;
        }

    
      public async Task<Notification> GetByTitleAsync(string title)
        {
            // _context. GetByTitleAsyncAsync.FirstOrDifUlt(t.t=>title==title);
            //return await Notification;
            return await _context.Notifications.FirstOrDefaultAsync(t => t.Title == title);
        }
    }
    }

