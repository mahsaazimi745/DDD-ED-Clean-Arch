using Software_Ar.Core.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Users
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public Email Email { get; protected set; }
        public PhoneNumber PhoneNumber { get; protected set; }
        public string FullName => $"{Name}{LastName}";
        public User() { }

        public User(string name, string lastName, Email email, PhoneNumber phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

    }

}
