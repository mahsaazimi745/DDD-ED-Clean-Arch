using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications
{
    public class EmailNotification:Notification
    {
        public EmailNotification() { }
        public EmailNotification(string title, string discription):base(title ,discription)
        {
        }
        public override void CreatNotificattion(Guid AdminId, string title, string discription)
        {
            base.CreatNotificattion(AdminId, title, discription);
        }
    }
}
