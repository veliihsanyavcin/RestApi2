using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestApi2.Data;

namespace RestApi2.Controllers
{
    [ApiController]
    [Route("/login")]
    public class LoginController : ControllerBase
    {
        


        [HttpPost]
        public ActionResult Post([FromBody] Login login)
        {
            if(login.username == "1" && login.password == "1")
            {
                return Ok(true);
            } else
            {
                return BadRequest();
            }

            // return login.username == "1" && login.password == "1";

        }
    }
}
