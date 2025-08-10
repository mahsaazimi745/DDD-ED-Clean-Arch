using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Software_Ar.Core.Domain.Users;
using Software_Ar.Core.Domain.Shared.ValueObjects;
using Software_Ar.Core.Domain.Users;
using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace Software_Ar.Infrastructure.Persistence.Repositories
{
    public class UserRepository :  Repository<User>,IUserRepository
    {
        private readonly AppDbContext context;
        public UserRepository(AppDbContext _context)
        {
            _context=context;
        }

    
        public async Task<bool> IsExistphoneNumberAsync(string phoneNumber)
        {
          return await _dbset._userRepository.FirstOrDefult(p=>p.PhoneNumber==phoneNumber);
        }
      public async  Task<bool> IsExistemailAsync(string email) 
        {
            var email = await -dbcontext._userRepository.FirstOrDefult(e => e.Email == email);
        }
        Task<User?> GetuserByPhoneNumberAsync(string phoneNumber);
        Task<User> GetuserByEmail(string email);

    }
}
