using SSDApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SSDApp.Controllers
{
    public class HouseholdController : ApiController
    {
        private DatabaseContext _db = new DatabaseContext();

        [HttpGet]
        public IHttpActionResult GetAllUSers()
        {
            Response res = new Response();

            var hhs = _db.users.ToList();

            res.error = false;
            res.data = hhs;
            res.version = "1.0.0";
            res.env = "Test/Environment";

            return Ok(res);
        }
    }
}
