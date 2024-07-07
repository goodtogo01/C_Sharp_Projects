using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAssuredFrameWorks
{
    public class Helpers<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseUrl = "https://reqres.in/";

        public RestClient SetUrl(string endpoint) { 
        
            var url = Path.Combine(baseUrl, endpoint);  
            //var url = baseUrl + endpoint;
            var restClient = new RestClient(url);
            return restClient;

        }

        public RestResponse GetResponse(RestClient client, RestRequest request)
        {
            var queryRes = (RestResponse)client.Execute(request);
            Console.WriteLine(queryRes);
            return queryRes;

        }

        public DTO GetContent<DTO>(RestResponse response)
        {
            var content = response.Content;
            DTO dto = JsonConvert.DeserializeObject<DTO>(content);    

            return dto;
        }
     

        public RestRequest GetRequest() { 
            
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");    
            return restRequest; 
        }

        public RestRequest PostRequest(string payload) {

            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);   
            return restRequest; 
        
        }
        public RestRequest PutRequest() { 
            
            var request = new RestRequest(Method.PUT);  
            request.AddHeader("Accept", "application/json");    
          

            return request;
        }

        public RestRequest DeleteRequest() {
            var request = new RestRequest(Method.DELETE);   
            request.AddHeader("Accept", "application/json");
            return request;
        }

        
    }
}
