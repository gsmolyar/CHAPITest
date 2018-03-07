using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CHAPIService
{
    public class CHAPIController : ApiController
    {

        //public string GetURL()
        //{
        //    //var url = this.Url.Link("Default", new { Controller = "MyMvc", Action = "MyAction", param1 = 1, param2 = "somestring" });
        //    var url = this.Url.Link("Default", new { Controller = "CHAPI", Action = "Post" });
        //    return url;
        //}

        public string GetOutputTarget()
        {
            return System.Configuration.ConfigurationManager.AppSettings["OutputTarget"];
        }


        public IEnumerable<string> GetURL()
        {
            // returns /api/values/123
            string url = Url.Route("DefaultApi", new { controller = "CHAPI" });
            return new string[] { "value1", "value2" };
        }


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
