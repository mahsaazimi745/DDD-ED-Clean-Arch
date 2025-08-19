using Software_Ar.Core.Domain.Users;
using Software_Ar.Core.Domain.Shared;
using Software_Ar.Core.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Users
{
    public interface IUserRepository : IRepository<User>
    {
        //Task<bool> IsExistphoneNumberAsync(PhoneNumber phoneNumber);
        //Task<bool> IsExistemailAsync(Email email);
        Task<User?> GetuserByPhoneNumberAsync(PhoneNumber phoneNumber);
        Task<User> GetuserByEmail(Email email);

    }
}
