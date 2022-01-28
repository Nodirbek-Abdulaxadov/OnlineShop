using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineShop.Admin.Models;
using OnlineShop.API.ViewModels;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineShop.Admin.Controllers
{
    public class HomeController : Controller
    {
        string baseUrl = "https://localhost:44335/api";
        HttpClient client;
        public async Task<IActionResult> Index()
        {
            client = new HttpClient();
            var json = await client.GetStringAsync(String.Format($"{baseUrl}/category/getall"));
            List<CategoryViewModel> list = JsonConvert.DeserializeObject<List<CategoryViewModel>>(json);
            return View(list);
        }

        public async Task<IActionResult> Products(Guid id)
        {
            client = new HttpClient();
            string url = String.Format($"{baseUrl}/Product/getall/{id}");
            var json = await client.GetStringAsync(url);
            List<Product> list = JsonConvert.DeserializeObject<List<Product>>(json);
            return View(list);
        }
    }
}
