using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Context;
using Application.Interfaces;

namespace Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        public productController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _productService.GetAllAsync());
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _productService.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            await _productService.UpdateAsync(id, product);
            return Ok();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product reminder)
        {
            await _productService.AddAsync(reminder);
            return Ok();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.RemoveAsync(id);
            return Ok();
        }
        [HttpDelete("Category/{id}")]
        public async Task DeleteAllByCategoryId(int id)
        {
            await _productService.DeleteAllByCategoryIdAsync(id);
        }

        [HttpGet("Category/{categoryId}")]
        public async Task<IEnumerable<Product>> GetAllByCategoryId(int id)
        {
            return await _productService.GetAllBycategoryIdAsync(id);
        }

    }
}

