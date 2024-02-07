using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICategory
    {
        Task<IEnumerable<Category>> GetCategory();
        Task<Category> GetCategorybyId(int Id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task DeleteCategory(int Id);


    }
}
