using Microsoft.AspNetCore.Mvc;
using Lab09.DTOs;
using Lab09.Services;

namespace Lab09.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _service.GetById(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Create(CategoryDto dto)
        {
            _service.Add(dto);
            return Ok(new { message = "Category created" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryDto dto)
        {
            _service.Update(id, dto);
            return Ok(new { message = "Category updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok(new { message = "Category deleted" });
        }
    }
}