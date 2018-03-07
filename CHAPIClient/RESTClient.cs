using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;


namespace CHAPIClient
{
    public enum HTTPVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RESTClient
    {
        public string EndPoint { get; set; }
        public string Content { get; set; }
        public HTTPVerb HttpMethod { get; set; }

        public RESTClient(string Uri, string content, HTTPVerb verb)
        {
            EndPoint = Uri;
            this.Content = content;
            HttpMethod = verb;

        }

        public string MakeRequest()
        {
            string responseVal = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);
            request.Method = HttpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException(String.Format("Unexpected Error: {0} - {1}", response.StatusCode, response.StatusDescription));
                }

                // Process response stream 
                using (Stream responseStream = response.GetResponseStream())
                {
                    // Set response value
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            responseVal = reader.ReadToEnd();
                        }
                    }

                }
            }

            return responseVal;

        }

        //public HttpStatusCode PostDtoSync(T dto, String resource)

        //{
        //    HttpClient client = new HttpClient();

        //    //var client = new RestClient(serviceBaseUrl);
        //    //var request = CreateJsonRequest(resource);
        //    //request.AddBody(dto);
        //    //request.Method = Method.POST;

        //    //var response = client.Execute(request);
        //    //return response.StatusCode;

        //}


    }
}
