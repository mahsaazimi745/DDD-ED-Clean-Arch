using FluentResults;
using Software_Ar.Core.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.NotificationAgg.Factories
{
    public static class EmailNotificationFactory
    {
        public static Result< EmailNotification> Create(
     Guid userId,
    Guid adminId,
    string title,
    string description,
    Guid notificationId
            )
        {
            //if (string.IsNullOrWhiteSpace(title)) 
            //   Result.Fail("تاینل نیابد حالی باشد ",nameof(title));
            if (string.IsNullOrEmpty(title))
                return Result.Fail<EmailNotification>("عنوان نمیتواند خالی باشد  ");

            if (string.IsNullOrEmpty(description))
                return Result.Fail<EmailNotification>("متن پیام نمیتواند خالی باشد ");


            return Result.Ok(new EmailNotification (Guid.NewGuid(),userId,adminId,title, description, notificationId));

            //    return new EmailNotification(
            //Guid.NewGuid(),   // id جدید برای Child
            //userId,           // userId همان کاربر دریافت‌کننده
            //adminId,          // adminId همان سازنده
            //title,
            //description,
            //notification);
        }
    }
}
