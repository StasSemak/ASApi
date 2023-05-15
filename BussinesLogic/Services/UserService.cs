using AutoMapper;
using BussinesLogic.DTOs.User;
using BussinesLogic.Interfaces;
using Data.Data;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly Data.Data.DbContext context;
        private readonly IMapper mapper;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager,
            Data.Data.DbContext context, IMapper mapper) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
            this.mapper = mapper;
        }


        public async Task<UserDto> GetUserAsync(string id)
        {
            var user = await context.Users.Include(x => x.Role).Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return mapper.Map<UserDto>(user);
        }

        public ICollection<UserDto> GetUsers()
        {
            var users = context.Users.Include(x => x.Role).ToList();
            return mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> LoginAsync(UserLoginDto loginModel)
        {
            var user = await userManager.FindByEmailAsync(loginModel.Email);
            if (user == null || !await userManager.CheckPasswordAsync(user, loginModel.Password))
                throw new Exception("Invalid email or password!");

            await signInManager.SignInAsync(user, true);
            return mapper.Map<UserDto>(user);
        }

        public async Task RegisterAsync(UserRegisterDto registerModel)
        {
            var user = mapper.Map<User>(registerModel);
            user.RoleId = context.Roles.Where(x => x.Name == registerModel.Role).FirstOrDefault().Id;
            var result = await userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded) throw new Exception("Register process failed!");
        }
    }
}
