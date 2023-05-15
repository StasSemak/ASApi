using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.DTOs.Category
{
    public class CategoryEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageBase64 { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
    }
}
