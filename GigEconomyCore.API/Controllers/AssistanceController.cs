using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Handler;
using GigEconomyCore.Domain.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GigEconomyCore.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AssistanceController : ControllerBase
    {
        private readonly AssistanceHandler assistanceHandler;

        public AssistanceController(AssistanceHandler assistanceHandler)
        {
            this.assistanceHandler = assistanceHandler;
        }

        [HttpGet("{id}")]
        public IActionResult GetAssistanceById([FromRoute]  int Id)
        {
            var response = (GenericCommandResult)this.assistanceHandler.Handler(Id);
        
            if(!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }


    }
}
