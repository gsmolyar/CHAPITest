using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CHAPITest.Controllers
{
    public class CHAPIController : ApiController
    {
        // GET: api/CHAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CHAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CHAPI
        public void Post([FromBody]string value)
        {
            Console.Write("Hello World");
            Console.ReadLine();
        }

        // PUT: api/CHAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CHAPI/5
        public void Delete(int id)
        {
        }
    }
}
