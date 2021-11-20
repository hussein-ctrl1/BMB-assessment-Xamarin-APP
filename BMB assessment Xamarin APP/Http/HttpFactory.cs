using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BMB_assessment_Xamarin_APP.Http
{
    public class HttpFactory
    {
        string BaseUrl = "https://localhost:44389/api/order";

        public async Task<HttpResponseMessage> GetResponse()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.BaseAddress = new Uri("https://localhost:44389/api/order");
            httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            HttpResponseMessage responseMessage = await httpClient.GetAsync(httpClient.BaseAddress).ConfigureAwait(true);
            return responseMessage;
        }
    }
}
