﻿using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Handler;
using GigEconomyCore.Domain.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GigEconomyCore.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AccidentController : ControllerBase
    {
        private readonly AccidentHandler accidentHandler;

        public AccidentController(AccidentHandler _accidentHandler)
        {
            this.accidentHandler = _accidentHandler;
        }

        [HttpPost("{accident}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accident))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostAccident(Accident accident)
        {
            var response = (GenericCommandResult)this.accidentHandler.HandlerAdd(accident);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accident))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAccidentById(int Id)
        {
            var response = (GenericCommandResult)this.accidentHandler.Handler(Id);
        
            if(!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

        [HttpGet("{status}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accident))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAccidentByStatus(string status)
        {
            var response = (GenericCommandResult)this.accidentHandler.Handler(status);

            if (!response.Success)
                return BadRequest(response);

            if (response.Data == null)
                return NoContent();

            return Ok(response.Data);
        }

    }
}
