using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingAPI.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult GetTest()
        {
            //var studet = st.FirstOrDefault((s) => s.stuID == stuid);
            //if (studet == null)
            //{
                //return NotFound();
            //}
            return Ok("Anwar");
        }
    }
}
