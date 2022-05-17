using Microsoft.AspNetCore.Mvc;
using Practice02_WebAPI.Services;

namespace Practice02_WebAPI.Controllers
{
    [Route("api/category")]
    public class CategoryController : Controller
    {
        private CategoryService categoryService;
        public CategoryController(CategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(categoryService.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
