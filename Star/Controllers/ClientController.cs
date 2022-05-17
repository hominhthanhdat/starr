using Microsoft.AspNetCore.Mvc;
using Practice02_WebAPI.Models;
using Practice02_WebAPI.Services;

namespace Practice02_WebAPI.Controllers
{
    [Route("api/client")]
    public class ClientController : Controller
    {
        private ClientService clientService;
        public ClientController(ClientService _clientService)
        {
            clientService = _clientService;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(clientService.FindAll());
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
                return Ok(clientService.Find(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        public IActionResult Create([FromBody] Client client)
        {
            try
            {
                return Ok(new
                {
                    Result = clientService.Create(client),
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
        public IActionResult Update([FromBody] Client client)
        {
            try
            {
                return Ok(new
                {
                    Result = clientService.Update(client),
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
                return Ok(clientService.Delete(id));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
