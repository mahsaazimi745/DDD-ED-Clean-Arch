using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Common
{
   public static class RegexPatterns
    {
        public const string IranPhoneNumber = @"^09\d{9}$";
        public const string Email = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    }
}
