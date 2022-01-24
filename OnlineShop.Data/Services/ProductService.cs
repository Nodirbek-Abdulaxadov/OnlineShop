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
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Product> AddProduct(Product newProduct)
        {
            _dbContext.Products.Add(newProduct);
            _dbContext.SaveChangesAsync();
            return Task.FromResult(newProduct);
        }

        public Task DeleteProduct(Guid id)
        {
            Product product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(product);
            _dbContext.SaveChangesAsync();
            return Task.FromResult(0);
        }

        public Task<List<Product>> GetAll() => _dbContext.Products.ToListAsync();

        public Task<Product> GetById(Guid id) => _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

        public Task<Product> UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChangesAsync();
            return Task.FromResult(product);
        }
    }
}
