using BussinesLogic.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    public interface ICategoryService
    {
        ICollection<CategoryDto> GetAll();
        Task<CategoryDto> GetCategoryAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto model);
        Task<CategoryDto> EditCategoryAsync(CategoryEditDto model);
    }
}
