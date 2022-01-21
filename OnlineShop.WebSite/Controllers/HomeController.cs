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
        List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = Guid.Parse("1ee8a3c9-0177-441d-aa72-e30029d6f157"),
                    Name = "Kamera",
                    Price = 800,
                    Description = "Texnologiya: Html5, Css3, Sass, Less, Bootstrap, Styled-components, Javascript, Es6, React, Redux, React-router-dom, Axios, Rest Api, Grid + Flexbox, Chrome Devtools, Postman, Git ",
                    ImageFileName = "p1.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Joystik",
                    Price = 200,
                    Description = "Texnologiya: Html5, Css3, Sass, Less, Bootstrap, Styled-components, Javascript, Es6, React, Redux, React-router-dom, Axios, Rest Api, Grid + Flexbox, Chrome Devtools, Postman, Git ",
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
                    Name = "Oxirgisi",
                    Price = 150,
                    Description = "",
                    ImageFileName = "p4.png"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Last",
                    Price = 150,
                    Description = "",
                    ImageFileName = "p6.png"
                }
            };
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            if (products.Count > 9)
            {
                var list = products.GetRange(products.Count - 9, 9);
                list.Reverse();
                return View(list);
            }
             
            return View(products);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View(products);
        }

        public IActionResult WhyUs()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }

        public IActionResult AddCard(Guid id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}
