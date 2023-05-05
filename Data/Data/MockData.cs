using Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public static class MockData
    {
        public static List<Role> GetRoles()
        {
            return new List<Role>
            {
                new Role()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User"
                },
                new Role()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Superuser"
                },
                new Role()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin"
                }
            };
        }
        public static List<User> GetUsers() 
        {
            IPasswordHasher<User> hasher = new PasswordHasher<User>();

            User user1 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "coolman123",
                Email = "mancool321@gmail.com",
                NormalizedEmail = "mancool321@gmail.com",
                NormalizedUserName = "coolman123",
                RoleId = GetRoles().Where(x => x.Name == "User").FirstOrDefault().Id
            };
            user1.PasswordHash = hasher.HashPassword(user1, "qwerty1234");

            User user2 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "john1997",
                Email = "john1997@gmail.com",
                NormalizedEmail = "john1997@gmail.com",
                NormalizedUserName = "john1997",
                RoleId = GetRoles().Where(x => x.Name == "User").FirstOrDefault().Id
            };
            user2.PasswordHash = hasher.HashPassword(user2, "strongpass0");

            User user3 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin",
                Email = "mymail@gmail.com",
                NormalizedEmail = "mymail@gmail.com",
                NormalizedUserName = "admin",
                RoleId = GetRoles().Where(x => x.Name == "Admin").FirstOrDefault().Id
            };
            user3.PasswordHash = hasher.HashPassword(user3, "aDmInPaSsWoRd1357");

            User user4 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "friend_of_admin",
                Email = "iamthebest@gmail.com",
                NormalizedEmail = "iamthebest@gmail.com",
                NormalizedUserName = "friend_of_admin",
                RoleId = GetRoles().Where(x => x.Name == "Superuser").FirstOrDefault().Id
            };
            user4.PasswordHash = hasher.HashPassword(user4, "hACkerw0ntgue55");

            return new List<User>() { user1, user2, user3, user4 };
        }
    }
}
