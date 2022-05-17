using Microsoft.AspNetCore.Mvc;
using Practice02_WebAPI.Models;
using Practice02_WebAPI.Services;

namespace Practice02_WebAPI.Controllers
{
    [Route("api/business")]
    public class BusinessController : Controller
    {
        private BusinessService businessService;
        public BusinessController(BusinessService _businessService)
        {
            businessService = _businessService;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(businessService.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("find/{id}")]
        public IActionResult Find(int id)
        {
            try
            {
                return Ok(businessService.Find(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] Business business)
        {
            try
            {
                return Ok(new
                {
                    Result = businessService.Create(business),
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPut("update")]
        public IActionResult Update([FromBody] Business business)
        {
            try
            {
                return Ok(new
                {
                    Result = businessService.Update(business),
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(businessService.Delete(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("updateStatus/{id}")]
        public IActionResult UpdateStatus(int id)
        {
            try
            {
                return Ok(new
                {
                    Result = businessService.UpdateStatus(id),
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
