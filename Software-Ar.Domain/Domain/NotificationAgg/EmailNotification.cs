using Software_Ar.Core.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications
{
    public class EmailNotification : BaseEntity
    {
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public Guid AdminId { get; protected set; }
        public  Guid NotificationId  { get; protected set; }
        public Guid UserId { get; protected set; }
        //public EmailNotification() { }
    internal EmailNotification(Guid id, Guid userId, Guid adminId, string title, string description, Guid notificationId) : base(id)
        {
            UserId = userId;
            AdminId = adminId;
            Title = title;
            Description = description;
            NotificationId = notificationId;

        }
       // public static EmailNotification Create(
  
       //)
       // {
       //     return new EmailNotification(
       //   Guid.NewGuid(),   // id جدید برای Child
       // userId,           // userId همان کاربر دریافت‌کننده
       // adminId,          // adminId همان سازنده
       // title,
       // description,
       // notification
       //         );
        }





    }
}
