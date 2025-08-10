using FluentResults;
using Software_Ar.Core.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Notifications.Factories
{
   public static class NotificationFactory
    {
        public static Result<Notification> Create( string title ,
            string discription ) 
        { 
            if(string.IsNullOrEmpty(title))
                return Result.Fail<Notification>("عنوان نمیتواند خالی باشد  ");

            if (string.IsNullOrEmpty(discription))
                return Result.Fail<Notification>("متن پیام نمیتواند خالی باشد ");


            return Result.Ok(new Notification(title, discription)); 
        }
    }
}
