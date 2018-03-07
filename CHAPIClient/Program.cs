using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Configuration;
using CHAPITest;

namespace CHAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the service URI

            //var actionUrl = .Action("Content", "Import", new
            //{
            //    httproute = true,
            //    area = "Orchard.ImportExport"
            //});
            //IServiceProvider service = new CHAPITest.Controllers.CHAPIController();
            //CHAPITest.Controllers.CHAPIController.GetURL
            //string uri = Url.Action("POST", "CHAPIController", new { }, HttpWebRequest.Url.Scheme);

            //var url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            //item.Url = url.Action("POST", "CHAPI");


            //// Call REST client with input string
            //RESTClient restClient = new RESTClient("/api/CHAPI", "Hello, World", HTTPVerb.POST);
            //string result = restClient.MakeRequest();


            //TODO: establish Web API connection to the service

            // Instantiate the Factory

            //TODO: decouple Factory from service - extract Factory code into a separate class either in the client or another project
            string outputTarget = System.Configuration.ConfigurationManager.AppSettings["OutputTarget"];
            CHAPITest.OutputFactory outputFactory = new CHAPITest.OutputFactory(outputTarget);

            IOutputWriter outWriter = outputFactory.CreateOutputWriter();
            outWriter.WriteOutput("Hello World");

        }
    }
}
