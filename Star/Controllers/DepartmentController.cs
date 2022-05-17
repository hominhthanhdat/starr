using Microsoft.AspNetCore.Mvc;
using Star.Models;

using Star.Services;

namespace Star.Controllers
{
    [Route("api/department")]
    public class DepartmentController : Controller
    {
        private DepartmentService deparmentService;
        public DepartmentController(DepartmentService _deparmentService)
        {
            deparmentService = _deparmentService;
        }
        //Show data
        [Produces("application/json")]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(deparmentService.GetAll());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //create new
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
      
        public IActionResult Create([FromBody] Department department)
        {
            try
            {
                return Ok(new
                {
                    Result = deparmentService.Create(department)
                }) ;
            }
            catch
            {

                return BadRequest();
            }
        }

        //update
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPut("update")]
        //[FromBody] Book book
        public IActionResult Update([FromBody] Department department)
        {
            try
            {
                return Ok(new
                {
                    Result = deparmentService.Update(department)
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        //update status

        [Produces("application/json")]
        [HttpGet("changestatus/{id}")]
        //[FromBody] Book book
        public IActionResult ChangeStatus(int id)
        {
            try
            {
                return Ok(new
                {
                    Result = deparmentService.changeStatus(id)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
