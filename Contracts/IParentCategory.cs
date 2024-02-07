using Entitiess.Models;

namespace Contracts
{
    public interface IParentCategory
    {
        Task<IEnumerable<ParentCategory>> GetParentCategories();
        Task<ParentCategory> GetParentCategoryById(int id);
        Task<ParentCategory> AddParentCategory(ParentCategory parentCategory);
        Task<ParentCategory> UpdateParentCategory(ParentCategory parentCategory);
        Task DeleteParentCategory(int id);
    }
}
