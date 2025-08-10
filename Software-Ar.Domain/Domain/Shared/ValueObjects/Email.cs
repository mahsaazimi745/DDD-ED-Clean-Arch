using FluentResults;
using Software_Ar.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Shared.ValueObjects
{
   public  class Email:ValueObject
    {
        public string Value { get; }
        public Email() { }

        public Email(string value)
        {
            Value = value;
        }
       public static Result<Email> Create(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return Result.Fail<Email>("ایمیل نمیتواند خالی باشد ");

            if (!Regex.IsMatch(input, RegexPatterns.Email))
                return Result.Fail<Email>("ایمیل نامعتبر است .");

            return Result.Ok(new Email(input.Trim()));

        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

    }
}
