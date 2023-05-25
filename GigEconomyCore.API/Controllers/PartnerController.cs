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
    public class PartnerController : ControllerBase
    {
        private readonly PartnerHandler partnerHandler;

        public PartnerController(PartnerHandler partnerHandler)
        {
            this.partnerHandler = partnerHandler;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Partner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPartnerById(int Id)
        {
            var response = (GenericCommandResult)this.partnerHandler.GetPartner(Id);
        
            if(!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        [HttpGet("{nationalId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Partner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPartnerByNationalId(int nationalId)
        {
            var response = (GenericCommandResult)this.partnerHandler.GetPartner(nationalId);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        [HttpGet("{nationalId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Partner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostPartner(Partner Partner)
        {
            var response = (GenericCommandResult)this.partnerHandler.Handler(nationalId);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }
    }
}
