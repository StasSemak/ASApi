﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.DTOs.Category
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
        public string ImageBase64 { get; set; }
        public string Description { get; set; }
    }
}
