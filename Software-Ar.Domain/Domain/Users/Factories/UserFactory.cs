using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;
using Software_Ar.Core.Domain.Users;
using Software_Ar.Core.Domain.Shared.ValueObjects;

namespace Software_Ar.Core.Domain.Users.Factories
{
    public static class UserFactory
    {
        public static Result<User> Create(
            string name ,
            string lastName, 
            string email,
            string phoneNumber
            )
        { 
            if (string.IsNullOrWhiteSpace(name) )
                throw new ArgumentNullException("اسم الزامی است ",nameof(name));
            if (string.IsNullOrWhiteSpace(lastName) )
                throw new ArgumentNullException("فامیل الزامی است ",nameof(lastName));

            /*  if (string.IsNullOrWhiteSpace(email) ) 
                  throw new ArgumentNullException("ایمیل الزامی است ",nameof(email));*/
            /* if (string.IsNullOrWhiteSpace(phoneNumber) )
                 throw new ArgumentNullException("شماره تلفن الزامی است ",nameof(phoneNumber));*/
            /*  var emailResult = Email.Create(email);
              if (emailResult.IsFail)
                  return Result.Failure<User>(emailResult.Error);

              var phoneResult = PhoneNumber.Create(phoneNumber);
              if (phoneResult.IsFailure)
                  return Result.Failure<User>(phoneResult.Error);*/
            var emailResult = Email.Create(email);

            if (emailResult.IsFailed)
                return Result.Fail<User>(emailResult.Errors.First().Message);

            var phoneResult = PhoneNumber.Create(phoneNumber);

            if (phoneResult.IsFailed)
                return Result.Fail<User>(phoneResult.Errors.First().Message);

            /*  return new User (name,fullName,email,phoneNumber
                 );*/

            return Result.Ok(new User(
        name,
        lastName,
        emailResult.Value,
        phoneResult.Value
        ));
        }
    }
}
