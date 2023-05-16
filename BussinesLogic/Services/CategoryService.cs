using AutoMapper;
using BussinesLogic.DTOs.Category;
using BussinesLogic.Helpers;
using BussinesLogic.Interfaces;
using Data.Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly Data.Data.DbContext context;
        private readonly IMapper mapper;

        public CategoryService(Data.Data.DbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto model)
        {
            var category = mapper.Map<Category>(model);
            category.Image = ImageWorker.SaveImage(model.ImageBase64);
            int count = await context.Categories.CountAsync();
            category.Priority = count + 1;

            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();

            return mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> EditCategoryAsync(CategoryEditDto model)
        {
            var category = await context.Categories
                                        .SingleOrDefaultAsync(x => x.Id == model.Id);
            if (category == null) throw new Exception("Category not found!");

            category.Name = model.Name;
            category.Description = model.Description;
            category.Priority = model.Priority;
            if (!string.IsNullOrEmpty(model.ImageBase64))
            {
                ImageWorker.RemoveImage(category.Image);
                category.Image = ImageWorker.SaveImage(model.ImageBase64);
            }

            context.Categories.Update(category);
            await context.SaveChangesAsync();

            return mapper.Map<CategoryDto>(category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await context.Categories
                                        .Where(x => x.Id == id)
                                        .Where(x => x.IsDeleted == false)
                                        .SingleOrDefaultAsync();
            if (category == null) throw new Exception("Category not found!");

            category.IsDeleted = true;
            context.Categories.Update(category);
            await context.SaveChangesAsync();
        }

        public ICollection<CategoryDto> GetAll()
        {
            var categories = context.Categories
                                    .Where(x => x.IsDeleted == false)
                                    .OrderBy(x => x.Priority)
                                    .ToList();
            return mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            var category = await context.Categories
                                        .Where(x => x.Id == id)
                                        .Where(x => x.IsDeleted == false)
                                        .FirstOrDefaultAsync();
            if (category == null) throw new Exception("Category not found!");

            return mapper.Map<CategoryDto>(category);
        }
    }
}
