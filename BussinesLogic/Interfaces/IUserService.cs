using BussinesLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    public interface IUserService
    {
        Task RegisterAsync(UserRegisterDto registerModel);
        Task<UserDto> LoginAsync(UserLoginDto loginModel);
        ICollection<UserDto> GetUsers();
        Task<UserDto> GetUserAsync(string id);
    }
}
