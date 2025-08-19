using Software_Ar.Core.Domain.Shared;
using Software_Ar.Core.Domain.Shared.ValueObjects;
using Software_Ar.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications
{
    public class Notification:BaseAggregateRoot
    {
        public Guid Id { get;private set; }
        public string Title { get; private set; }
        public string Dicription { get; private set; }
        public NotificationType Type { get; }
        #region navigation
        public Guid UserId {  get; private set; }

        #endregion
        public EmailNotification EmailDetail { get; private set; }
        public SmsNotification SmsDetail { get; private set; }
        public Notification() { }

        internal Notification(
          string title,
          string discription
            ) 
        {
            Id = Guid.NewGuid();
            Title = title;
            Dicription = discription;
        }
   

       

    }
}
