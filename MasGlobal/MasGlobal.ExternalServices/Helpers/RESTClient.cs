using System.Net.Http;

namespace MasGlobal.ExternalServices.Helpers
{
    public static class RESTClient
    {
        /// <summary>
        /// Method for calling a REST service with a Get method
        /// </summary>
        /// <param name="url">URL of the exposed service</param>
        /// <returns>Response of the request</returns>
        public static HttpResponseMessage GetHttpResponse(string url)
        {
            HttpResponseMessage objHttpResponseMessage = null;
            using (HttpClient client = new HttpClient())
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
            {                
                objHttpResponseMessage = client.SendAsync(request).Result;
            }

            return objHttpResponseMessage;
        }
    }
}
