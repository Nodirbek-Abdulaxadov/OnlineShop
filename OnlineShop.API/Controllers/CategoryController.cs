using Microsoft.AspNetCore.Mvc;
using OnlineShop.API.ViewModels;
using OnlineShop.Data.Models;
using OnlineShop.Data.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var modelList = await _service.GetAll();
            List<CategoryViewModel> vlist = new List<CategoryViewModel>();
            foreach (var item in modelList)
            {
                vlist.Add((CategoryViewModel)item);
            }
            return Ok(vlist);
        }

        [HttpGet, Route("getalljson")]
        public async Task<IActionResult> GetAllJson()
        {
            var res = await _service.GetAllJson();
            return Ok(res);
        }
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(CategoryViewModel viewModel)
        {
            var res = await _service.AddCategory((Category)viewModel);
            return Ok(res);
        }
    }
}
