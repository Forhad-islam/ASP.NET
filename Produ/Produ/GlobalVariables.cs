using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Produ
{
    public class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVariables ()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:65493/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
        }
    }
}