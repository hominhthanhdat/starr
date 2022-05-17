using Microsoft.AspNetCore.Mvc;
using Practice02_WebAPI.Models;
using Practice02_WebAPI.Services;

namespace Practice02_WebAPI.Controllers
{
    [Route("api/request")]
    public class RequestController : Controller
    {
        private RequestService requestService;
        public RequestController(RequestService _requestService)
        {
            requestService = _requestService;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(requestService.FindAll());
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
                return Ok(requestService.Find(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] Request request)
        {
            try
            {
                return Ok(new
                {
                    Result = requestService.Create(request),
                });
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("updateStatus/{id}/{status}")]
        public IActionResult UpdateStatus(int id, short status)
        {
            try
            {
                return Ok(new
                {
                    Result = requestService.UpdateStatus(id, status),
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
        public IActionResult Update([FromBody] Request request)
        {
            try
            {
                return Ok(new
                {
                    Result = requestService.Update(request),
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
                return Ok(requestService.Delete(id));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
