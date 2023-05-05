using BussinesLogic.DTOs;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Profiles
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile() 
        {
            CreateMap<User, UserDto>()
                .ForMember(x => x.Role, o => o.MapFrom(s => s.Role.Name));
            CreateMap<UserDto, User>();

            CreateMap<UserRegisterDto, User>()
                .ForMember(x => x.Role, o => o.Ignore())
                .ForMember(x => x.NormalizedEmail, o => o.MapFrom(s => s.Email))
                .ForMember(x => x.NormalizedUserName, o => o.MapFrom(s => s.UserName));
        }
    }
}
