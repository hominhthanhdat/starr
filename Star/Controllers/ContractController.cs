using Microsoft.AspNetCore.Mvc;
using Star.Models;
using Star.Services;

namespace Star.Controllers
{
    [Route("api/contract")]
    public class ContractController : Controller
    {
        private ContractService contractService;
        public ContractController(ContractService _contractService)
        {
            contractService = _contractService;
        }

        //Show data by Client
        [Produces("application/json")]
        [HttpGet("getbyclient/{id}")]
        public IActionResult GetByClient(int id)
        {
            try
            {
                return Ok(contractService.FindingByIdClient(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //Show data by Employee
        [Produces("application/json")]
        [HttpGet("getbyemployee/{id}")]
        public IActionResult GetByEmployee(int id)
        {
            try
            {
                return Ok(contractService.FindingByIdEmployee(id));
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
      
        public IActionResult Create([FromBody] Contract contract)
        {
            try
            {
                return Ok(new
                {
                    Result = contractService.Create(contract)
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
        public IActionResult Update([FromBody] Contract contract)
        {
            try
            {
                return Ok(new
                {
                    Result = contractService.Update(contract)
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
        //[FromBody] Book book
        public IActionResult ChangeStatus(int id,int status)
        {
            try
            {
                return Ok(new
                {
                    Result = contractService.changeStatus(id,status)
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
