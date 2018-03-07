using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Configuration;
using CHAPIService;
using Factory;

namespace CHAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate the Factory
            OutputFactory outputFactory = new OutputFactory();

            // Ask Factory to instantiate the specific output writer based on configuration
            IOutputWriter outWriter = outputFactory.CreateOutputWriter();

            // Execute the output writer's functions directly
            outWriter.CustomProcessing();
            outWriter.WriteOutput("Hello World");

            // Invoke another class's functionality with OutputWriter injected dynamically at run time (Dependency Injection)
            TestRunner testRunr = new TestRunner(outWriter, "Hello World");
            // Execute the output writer's functions directly
            testRunr.CustomProcessing();
            testRunr.WriteOutput();







            //TODO: establish Web API connection to the service

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


        }
    }
}
