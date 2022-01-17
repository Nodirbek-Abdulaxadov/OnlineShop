using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(Guid id);
        Task<Product> AddProduct(Product newProduct);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(Guid id);
    }
}
