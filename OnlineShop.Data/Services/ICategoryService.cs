using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(Guid id);
        Task<Category> AddCategory(Category newCategory);
        Task<Category> UpdateCategory(Category Category);
        Task DeleteCategory(Guid id);
    }
}
