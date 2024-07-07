using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAssuredFrameWorks
{
    public class Demo<T>
    {
        public ListOfObjectDTO GetUsers(string endpoint) {
            var user = new Helpers<ListOfObjectDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.GetRequest();
            var response = user.GetResponse(url, request);

            ListOfObjectDTO content = user.GetContent<ListOfObjectDTO>(response);   
            return content;

        }

        public CreateUserDTO CreateUser(string endpoint, dynamic payload) { 
        
            var user = new Helpers<CreateUserDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.PostRequest(payload);
            var response = user.GetResponse(url, request);

            CreateUserDTO content = user.GetContent<CreateUserDTO>(response);
            return content; 

        }
    }
}
