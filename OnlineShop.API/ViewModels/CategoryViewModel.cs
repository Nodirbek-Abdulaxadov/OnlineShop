using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.ViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static explicit operator CategoryViewModel(Category v)
        {            
            return  new CategoryViewModel()
            {
                Id = v.Id,
                Name = v.Name
            };
        }

        public static explicit operator Category(CategoryViewModel v)
        {
            return new Category()
            {
                Id = v.Id,
                Name = v.Name,
                Products = null
            };
        }
    }
}
