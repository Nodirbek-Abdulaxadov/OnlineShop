using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Models;
using OnlineShop.Data.Services;
using System;
using System.Threading.Tasks;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var res = await _service.GetAll();
            return Ok(res);
        }

        [HttpGet, Route("get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var res = await _service.GetById(id);
            return Ok(res);
        }

        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(Product product)
        {
            var res = await _service.AddProduct(product);
            return Ok(res);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update(Product product)
        {
            var res = await _service.UpdateProduct(product);
            return Ok(res);
        }

        [HttpDelete, Route("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteProduct(id);
            return Ok();
        }
    }
}
