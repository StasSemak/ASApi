using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Role : IdentityRole
    {
        public ICollection<User> Users { get; set; }
    }
}
