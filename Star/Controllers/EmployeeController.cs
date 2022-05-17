using Microsoft.AspNetCore.Mvc;
using Star.Models;
using Star.Services;

namespace Star.Controllers
{
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        private EmployeeService employeeService;
        public EmployeeController(EmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        //Show data
        [Produces("application/json")]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(employeeService.FindingAll());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //Show data by Id
        [Produces("application/json")]
        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(employeeService.FindingById(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //Show data by name
        [Produces("application/json")]
        [HttpGet("getbyname/{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(employeeService.FindingByName(name));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        ////Show data by Sẻvice
        [Produces("application/json")]
        [HttpGet("getbyservice/{id}")]
        public IActionResult GetByService(int id)
        {
            try
            {
                return Ok(employeeService.FindingByService(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        ////Show data by Department
        [Produces("application/json")]
        [HttpGet("getbydepartment/{id}")]
        public IActionResult GetByDepartment(int id)
        {
            try
            {
                return Ok(employeeService.FindingByDepartment(id));
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
        //
        //
        public IActionResult Create([FromBody] Employee emp)
        {
            try
            {
                return Ok(new
                {
                    Result = employeeService.Create(emp)
                    
                    
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
        public IActionResult Update([FromBody] Employee emp)
        {
            try
            {
                return Ok(new
                {
                    Result = employeeService.Update(emp)
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        //update status
        [Produces("application/json")]
        [HttpGet("changestatus/{id}/{status}")]
       
        public IActionResult ChangeStatus(int id,int status)
        {
            try
            {
                return Ok(new
                {
                    Result = employeeService.changeStatus(id,status)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
