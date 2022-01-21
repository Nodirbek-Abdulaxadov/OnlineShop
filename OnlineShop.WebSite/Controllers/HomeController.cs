using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.WebSite.Controllers
{
    public class HomeController : Controller
    {
        List<Product> products;
        public HomeController()
        {
            products = new List<Product>()
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Kamera",
                    Price = 800,
                    Description = "",
                    ImageFileName = "p1.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Joystik",
                    Price = 200,
                    Description = "",
                    ImageFileName = "p2.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Dron",
                    Price = 500,
                    Description = "",
                    ImageFileName = "p3.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Kalonka",
                    Price = 150,
                    Description = "",
                    ImageFileName = "p4.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Kamera",
                    Price = 800,
                    Description = "",
                    ImageFileName = "p1.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Joystik",
                    Price = 200,
                    Description = "",
                    ImageFileName = "p2.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Dron",
                    Price = 500,
                    Description = "",
                    ImageFileName = "p3.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Kalonka",
                    Price = 150,
                    Description = "",
                    ImageFileName = "p4.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Kamera",
                    Price = 800,
                    Description = "",
                    ImageFileName = "p1.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Joystik",
                    Price = 200,
                    Description = "",
                    ImageFileName = "p2.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Dron",
                    Price = 500,
                    Description = "",
                    ImageFileName = "p3.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Kalonka",
                    Price = 150,
                    Description = "",
                    ImageFileName = "p4.png"
                }
            };
        }
        public IActionResult Index()
        {
            if (products.Count > 9)
            {
                return View(products.GetRange(0, 9));
            }
             
            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult WhyUs()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
