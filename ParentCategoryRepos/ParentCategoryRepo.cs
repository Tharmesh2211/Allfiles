using Contracts;
using Entitiess.Data;
using Entitiess.Models;
using Microsoft.EntityFrameworkCore;

namespace ParentCategoryRepos
{
    public class ParentCategoryRepo : IParentCategory
    {
        private readonly DataContext _dataContext;
        public ParentCategoryRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ParentCategory> AddParentCategory(ParentCategory parentCategory)
        {
            var res = await _dataContext.ParentCategory.AddAsync(parentCategory);
            await _dataContext.SaveChangesAsync();
            return res.Entity;
        }

        public async Task DeleteParentCategory(int id)
        {
            var result = await _dataContext.ParentCategory.FirstOrDefaultAsync(pc => pc.Id == id);
            if (result != null)
            {
                _dataContext.ParentCategory.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ParentCategory>> GetParentCategories()
        {
            return await _dataContext.ParentCategory.ToListAsync();
        }

        public async Task<ParentCategory> GetParentCategoryById(int id)
        {
            return await _dataContext.ParentCategory.FirstOrDefaultAsync(s => s.Id == id);

        }

        public async Task<ParentCategory> UpdateParentCategory(ParentCategory parentCategory)
        {
            var result = await _dataContext.ParentCategory.FirstOrDefaultAsync(s => s.Id == parentCategory.Id);
            if (result != null)
            {
                result.Parent_Category_Name = parentCategory.Parent_Category_Name;
                result.Description = parentCategory.Description;
                result.CreatedAt = parentCategory.CreatedAt;
                result.CreatedBy = parentCategory.CreatedBy;
                result.ModifiedAt = parentCategory.ModifiedAt;
                result.ModifiedBy = parentCategory.ModifiedBy;
                result.IsDeleted = parentCategory.IsDeleted;
                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
