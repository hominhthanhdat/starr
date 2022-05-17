using Microsoft.AspNetCore.Mvc;
using Star.Models;
using Star.Services;

namespace Star.Controllers
{
    [Route("api/account")]
    public class AccountController : Controller
    {
        private AccountService accountService;
        public AccountController(AccountService _accountService)
        {
            accountService = _accountService;
        }

        //show details data by client
        [Produces("application/json")]
        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(accountService.FindingById(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //update status
        [Produces("application/json")]
        [HttpGet("changestatus/{id}")]
  
        public IActionResult ChangeStatus(int id)
        {
            try
            {
                return Ok(new
                {
                    Result = accountService.changeStatus(id)
                });
            }
            catch
            {
                return BadRequest();
            }
        }


        //create
        [Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("create")]
        //
        public IActionResult Create([FromBody] Account account)
        {
            try
            {
                return Ok(new
                {
                    Result = accountService.Create(account)
                });
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
        public IActionResult Update([FromBody] Account account)
        {
            try
            {
                return Ok(new
                {
                    Result = accountService.Update(account)
                });
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
