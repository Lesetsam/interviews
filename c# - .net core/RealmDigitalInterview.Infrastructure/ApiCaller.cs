using Newtonsoft.Json;
using RealmDigitalInterview.Core;
using RealmDigitalInterview.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RealmDigitalInterview.Infrastructure
{
    public class ApiCaller : IProductRepository
    {
        public List<ApiResponseProduct> GetProductById(string productId)
        {
            string response = "";

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                response = client.UploadString("http://192.168.0.241/eanlist?type=Web", "POST", "{ \"id\": \"" + productId + "\" }");
            }
            var responseObject = JsonConvert.DeserializeObject<List<ApiResponseProduct>>(response);

            return responseObject;
        }

        public List<ApiResponseProduct> GetProductsByName(string productName)
        {
            string response = "";

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                response = client.UploadString("http://192.168.0.241/eanlist?type=Web", "POST", "{ \"names\": \"" + productName + "\" }");
            }
            var responseObject = JsonConvert.DeserializeObject<List<ApiResponseProduct>>(response);

            return responseObject;
        }
    }
}
