using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;
        public categoryController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _CategoryService.GetAllAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _CategoryService.GetByIdAsync(id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            await _CategoryService.AddAsync(category);
            return Ok();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Category category)
        {
            await _CategoryService.UpdateAsync(id, category);
            return Ok();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _CategoryService.RemoveAsync(id);
            return Ok();
        }
    }
}
