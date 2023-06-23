using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _3DModels.Models;
using _3DModels.Services;

namespace _3DModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<string> CreateProduct(Product product)
        {
            var result = _productService.CreateProduct(product);
            return Ok(result);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult<string> UpdateProduct(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            var result = _productService.UpdateProduct(product);
            return Ok(result);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteProduct(int id)
        {
            var result = _productService.DeleteProductById(id);
            return Ok(result);
        }
    }
}


