using InfoTrack.Net.Http.Configuration;
using InfoTrack.Net.Http.Configuration.Resiliency;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace AMLv4_API.RequestPerformer
{
    public static class RequestPerformer
    {
        public static T PerformRequest<T>(object request, string action, string additionalReference, int? orderId)
        {

            string convertedRequest = JsonConvert.SerializeObject(request);

            string baseUrl = "https://v4.amlsearch.co.uk/json/v4/";// ConfigurationManager.AppSettings["AmlV4BaseUrl"];
            string authorization = "BC2D900981B24313B5C5DE4EA9A2388A";//ConfigurationManager.AppSettings["AmlV4Authorization"];

            string res = PerformRequestAuthorization(convertedRequest, baseUrl, action, authorization, additionalReference, orderId);

            T result = JsonConvert.DeserializeObject<T>(res);

            return result;
        }

        public static string PerformRequestAuthorization(string request, string baseUrl, string action, string authorization, string additionalReference, int? orderId, bool logActionName = true)
        {
            string clientResult = string.Empty;

            //Log the authority request
            //long logId = LogAuthorityRequest(request, baseUrl + "/" + (logActionName ? action : ""), additionalReference, orderId);

            var requestHeaders = new Dictionary<string, string>();
            requestHeaders.Add("Authorization", authorization);
            
            var client = new InfoTrack.Net.Http.HttpClient(baseUrl, new HttpClientOptions
            {
                RequestHeaders = requestHeaders,
                RetryPolicy = Retry.OnAnyException()
                    .Every(5000)//Retry every 5 seconds
                    .StopAfter(5)//Stop after 5 attempts
            });

            var result = client.PostAsync(action, new System.Net.Http.StringContent(request));

            clientResult = result.Result.Content.ReadAsStringAsync().Result;

            //log the authority response
            // LogAuthorityResponse(logId, clientResult);


            return clientResult;
        }

    }


   

}
