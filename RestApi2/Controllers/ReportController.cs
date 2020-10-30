using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RestApi2.Data;


namespace RestApi2.Controllers
{
    [Route("/report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private RestApiContext _restApiContext;

        public static Park park = new Park();


        [HttpPost]
        public ActionResult Post([FromBody] Vehicle vehicle)
        {
            park.ParkOut(vehicle, _restApiContext);
            return Ok();

        }

        [HttpGet]
        public IEnumerable<Ticket> Get()
        {

            return park.GetParkOut(_restApiContext);

        }
    }
}
