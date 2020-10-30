using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RestApi2.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApi2.Controllers
{
    [Route("/report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public static Park park = new Park();
       
        [HttpPost]
        public ActionResult Post([FromBody] Vehicle vehicle)
        {
            park.ParkOut(vehicle);
            return Ok();

        }


        [HttpGet]
        public IEnumerable<Ticket> Get()
        {

            return park.GetParkOut();

        }




        // GET: /report
        //[HttpGet]
        //public IEnumerable<Ticket> Get(Ticket ticket)
        //{
        //    return park.GetParkOut();
        //}

        // GET: api/<ReportController>

        // GET api/<ReportController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ReportController>

        // PUT api/<ReportController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ReportController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
