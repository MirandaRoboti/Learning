using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreWindowsAuth.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreWindowsAuth.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    public class SendersController : Controller
    {
        [HttpGet]
        public string GetName (Members members)
        {

            return members.FirstName + " " + members.LastName;
            

        }

        [HttpPost]
        public string PostName([FromBody] Members members, string id)
        {
            return members.FirstName + " " + members.LastName;
        }
    }
}