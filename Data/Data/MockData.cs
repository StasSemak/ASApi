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
        static private string userRoleId = Guid.NewGuid().ToString();
        static private string superuserRoleId = Guid.NewGuid().ToString();
        static private string adminRoleId = Guid.NewGuid().ToString();
        public static List<Role> GetRoles()
        {
            return new List<Role>
            {
                new Role()
                {
                    Id = userRoleId,
                    Name = "User"
                },
                new Role()
                {
                    Id = superuserRoleId,
                    Name = "Superuser"
                },
                new Role()
                {
                    Id = adminRoleId,
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
                RoleId = userRoleId
            };
            user1.PasswordHash = hasher.HashPassword(user1, "qwerty1234");

            User user2 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "john1997",
                Email = "john1997@gmail.com",
                NormalizedEmail = "john1997@gmail.com",
                NormalizedUserName = "john1997",
                RoleId = userRoleId
            };
            user2.PasswordHash = hasher.HashPassword(user2, "strongpass0");

            User user3 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin",
                Email = "mymail@gmail.com",
                NormalizedEmail = "mymail@gmail.com",
                NormalizedUserName = "admin",
                RoleId = adminRoleId
            };
            user3.PasswordHash = hasher.HashPassword(user3, "aDmInPaSsWoRd1357");

            User user4 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "friend_of_admin",
                Email = "iamthebest@gmail.com",
                NormalizedEmail = "iamthebest@gmail.com",
                NormalizedUserName = "friend_of_admin",
                RoleId = superuserRoleId
            };
            user4.PasswordHash = hasher.HashPassword(user4, "hACkerw0ntgue55");

            return new List<User>() { user1, user2, user3, user4 };
        }

        public static List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Laptops",
                    Priority = 1,
                    Image = "laptop.jpg",
                    Description = "Cool laptops here"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Phones",
                    Priority = 3,
                    Image = "phone.jpg",
                    Description = "Great phones for everyone"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Monitors",
                    Priority = 2,
                    Image = "monitor.jpg",
                    Description = "Monitors for all uses"
                },
                new Category()
                {
                    Id = 4,
                    Name = "RAM",
                    Priority = 5,
                    Image = "ram.jpg",
                    Description = "Memory that your computer will enjoy"
                },
                new Category()
                {
                    Id = 5,
                    Name = "CPU",
                    Priority = 4,
                    Image = "cpu.jpg",
                    Description = "Processors smarter than Einstein"
                },
                new Category()
                {
                    Id = 6,
                    Name = "GPU",
                    Priority = 6,
                    Image = "gpu.jpg",
                    Description = "Best graphics for not only games"
                },
            };
        }
    } 
}
