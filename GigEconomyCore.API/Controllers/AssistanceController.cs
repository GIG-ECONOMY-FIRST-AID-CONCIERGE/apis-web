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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Assistance))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPartnerById(int Id)
        {
            var response = (GenericCommandResult)this.assistanceHandler.Handler(Id);
        
            if(!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        [HttpGet("{status}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Assistance))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAssistanceByStatus(string status)
        {
            var response = (GenericCommandResult)this.assistanceHandler.Handler(status);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

    }
}
