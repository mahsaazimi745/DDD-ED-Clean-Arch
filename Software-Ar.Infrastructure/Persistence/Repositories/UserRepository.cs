using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Software_Ar.Core.Domain.Users;
using Software_Ar.Core.Domain.Shared.ValueObjects;


namespace Software_Ar.Infrastructure.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context):base(context) 
        {
            _context = context;
               
        }


      //  public async Task<bool> IsExistphoneNumberAsync(PhoneNumber phoneNumber)
      //  {
      //      //return await _context._userRepository.FirstOrDefult(p=>p.PhoneNumber==phoneNumber);
      //      return await _context.Users.AnyAsync(p => p.PhoneNumber == phoneNumber);
      //  }
      //public async  Task<bool> IsExistemailAsync(Email email) 
      //  {
      //      //return await -context._userRepository.FirstOrDefult(e => e.Email == email);
      //      return await _context.Users.AnyAsync(e => e.Email == email);
      //  }
        //Task<User?> GetuserByPhoneNumberAsync(string phoneNumber);
        //Task<User> GetuserByEmail(string email);

        public async Task<User?> GetuserByPhoneNumberAsync(PhoneNumber phoneNumber)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task<User> GetuserByEmail(Email email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

    }
}
