using FluentResults;
using Software_Ar.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Software_Ar.Core.Domain.Shared.ValueObjects
{
    public class PhoneNumber:ValueObject
    {
        public string Value { get; }
        public PhoneNumber() { }
        public PhoneNumber(string value) 
        { Value = value; }
        /* public static PhoneNumber Creat(string value) 
         { 

             return new PhoneNumber(value);
         }*/
        public static Result<PhoneNumber> Create(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return Result.Fail<PhoneNumber>("شماره تلفن الزامی است");

            /*     if (!Regex.IsMatch(phone, @"^09\d{9}$"))
                     return Result.Failure<PhoneNumber>("Phone number must start with 09 and be 11 digits.");*/
            /*   if (!Regex.IsMatch(phone, @"^09\d{9}$"))
                   return Result.Fail<PhoneNumber>("شماره نامعتبر است");*/
            if (!Regex.IsMatch(input, RegexPatterns.IranPhoneNumber))
                return Result.Fail<PhoneNumber>("شماره تلفن نامعتبر است.");

            //return Result.Success(new PhoneNumber(phone));
              return Result.Ok(new PhoneNumber(input));
            
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
