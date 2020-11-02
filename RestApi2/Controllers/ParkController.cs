using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi2.Data;



namespace RestApi2.Controllers
{
    [ApiController]
    [Route("/ticket")]
    public class ParkController : ControllerBase
    {

        public static Park park = new Park();

        private RestApiContext _restApiContext;
        public ParkController(RestApiContext context)
        {
            _restApiContext = context;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return NotFound("");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            park.ParkIn(vehicle, _restApiContext);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return park.GetParkIn(_restApiContext);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ticket ticket)
        {
            if (ticket.Id==1)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest();
            }
        }





    }
}