using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WF.PROTESTO.Models;
using System.Collections.Generic;

namespace WF.PROTESTO
{
    public class ApiClient
    {
        static HttpClient client = new HttpClient();
        public static HttpResponseMessage ImportarCarga(string endpoint, string json)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            dynamic dnyJson = JsonConvert.DeserializeObject<List<Protesto>>(json);

            foreach (var item in dnyJson)
            {
                string strJson = JsonConvert.SerializeObject(item);
                StringContent httpContent = new StringContent(strJson, Encoding.UTF8, "application/json");
                response = client.PostAsync(new Uri(endpoint), httpContent).Result;
            }
            
            return response;
        }

        public static HttpResponseMessage RetornarProtestos(string endpoint)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            response = client.GetAsync(new Uri(endpoint)).Result;
            
            return response;
        }

        public static HttpResponseMessage RetornarProtestoById(string endpoint, int idprotesto)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            response = client.GetAsync(new Uri(endpoint + idprotesto)).Result;

            return response;
        }

        public static HttpResponseMessage SalvarProtesto(string endpoint, Protesto protesto)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            string json = JsonConvert.SerializeObject(protesto);
            StringContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            response = client.PutAsync(new Uri(endpoint + '/' + protesto.ProtestoID), httpContent).Result;

            return response;
        }
    }
}