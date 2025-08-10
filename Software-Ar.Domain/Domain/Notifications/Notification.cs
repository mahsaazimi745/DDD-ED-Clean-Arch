using Software_Ar.Core.Domain.Shared.ValueObjects;
using Software_Ar.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications
{
    public class Notification
    {
        public string Id { get;private set; }
        public string Title { get; private set; }
        public string Dicription { get; private set; }
        public NotificationType notificationType { get; }
        #region navigation
        public Guid UserId {  get; private set; }
        public User Users { get; private set; }
        #endregion
        public Notification() { }
        public Notification(
          string title,
          string discription
            ) 
        {
            Id = Id;
            Title = title;
            Dicription = discription;
        }
        public virtual void CreatNotificattion(Guid AdminId, string title ,string discription)
        {    
            Guid = AdminId;
            Title = title;
            Dicription=discription;
            return;
        }
       

    }
}
