using Contracts;
using Entitiess.Data;
using Entitiess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentCategoryRepos
{
    public class CategoryRepo : ICategory
    {
        private readonly DataContext appDbContext;

        public CategoryRepo(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await appDbContext.Category.ToListAsync();
        }

        public async Task<Category> GetCategorybyId(int Id)
        {
            return await appDbContext.Category
                .FirstOrDefaultAsync(p => p.CategoryId == Id);
        }

        public async Task<Category> AddCategory(Category category)
        {
            var result = await appDbContext.Category.AddAsync(category);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            var result = await appDbContext.Category
                .FirstOrDefaultAsync(p => p.CategoryId == category.CategoryId);

            if (result != null)
            {
                result.CategoryName = category.CategoryName;
                result.CategoryDescription = category.CategoryDescription;
                result.ParentCategory = category.ParentCategory;
                result.CreatedAt = category.CreatedAt;
                result.CreatedBy = category.CreatedBy;
                result.ModifiedBy = category.ModifiedBy;
                result.ModifiedAt = category.ModifiedAt;

                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task DeleteCategory(int Id)
        {
            var result = await appDbContext.Category
                .FirstOrDefaultAsync(p => p.CategoryId == Id);
            if (result != null)
            {
                appDbContext.Category.Remove(result);
                await appDbContext.SaveChangesAsync();
            }

        }

    }
}
