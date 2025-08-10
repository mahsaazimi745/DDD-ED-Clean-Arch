using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications
{
    public  class SmsNotification:Notification
    {
        public SmsNotification() { }
        public SmsNotification(string title ,string discription ):base(title,discription)
        {

        }
        public override void CreatNotificattion(Guid AdminId, string title, string discription)
        {
            base.CreatNotificattion(AdminId, title, discription);
        }

    }
}
