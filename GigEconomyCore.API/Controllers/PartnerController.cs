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

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Partner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{Id}")]
        public IActionResult GetPartnerById(int Id)
        {
            var response = (GenericCommandResult)this.partnerHandler.GetPartner(Id);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Partner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostPartner([FromBody] Partner partner)
        {
            var response = (GenericCommandResult)this.partnerHandler.AddPartner(partner);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }
    }
}
