using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.DataLayer;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Category> AddCategory(Category newCategory)
        {
            _dbContext.Categories.Add(newCategory);
            _dbContext.SaveChangesAsync();
            return Task.FromResult(newCategory);
        }

        public Task DeleteCategory(Guid id)
        {
            Category category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            _dbContext.Remove(category);
            _dbContext.SaveChangesAsync();
            return Task.FromResult(0);
        }

        public Task<List<Category>> GetAll()
        {
            return _dbContext.Categories
                .Include(p => p.Products).ToListAsync();
        }

        public Task<Category> GetById(Guid id)
        {
            Category category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(category);
        }

        public Task<Category> UpdateCategory(Category Category)
        {
            _dbContext.Categories.Update(Category);
            _dbContext.SaveChangesAsync();
            return Task.FromResult(Category);
        }
    }
}
