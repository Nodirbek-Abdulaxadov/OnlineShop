using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Models;
using OnlineShop.Data.Services;
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
            var res = await _service.GetAll();
            return Ok(res);
        }
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(Category product)
        {
            var res = await _service.AddCategory(product);
            return Ok(res);
        }
    }
}
