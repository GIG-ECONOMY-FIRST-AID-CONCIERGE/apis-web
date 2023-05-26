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
        public IActionResult GetAssistanceById([FromRoute]  int id)
        {
            var response = (GenericCommandResult)this.assistanceHandler.Handler(id);
        
            if(!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accident))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostAddAssistance([FromBody] Assistance assistance)
        {
            var response = (GenericCommandResult)this.assistanceHandler.HandlerAddAssistance(assistance);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

    }
}
