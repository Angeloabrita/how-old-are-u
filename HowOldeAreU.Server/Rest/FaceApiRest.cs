using HowOldeAreU.Server.Dto;
using HowOldeAreU.Server.Interfaces;
using HowOldeAreU.Server.Models;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;


namespace HowOldeAreU.Server.Rest
{
    public class FaceApiRest : Ifaces
    {
        private readonly IConfiguration _configuration;
      

        public FaceApiRest(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
           
        }

        public async Task<GenericResponse<FaceModel>> GetFaces(string image)
        {
            // Retrieve token information from configuration
            var apiTokenSettings = _configuration.GetSection("api_token").Get<Dictionary<string, string>>();
            string token = apiTokenSettings["token"];

            // Construct the API request
            var requestUri = "https://api.everypixel.com/v1/faces";
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri);

            // Set API token authorization header
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", token);

            var response = new GenericResponse<FaceModel>();
            
            using(var client = new HttpClient())
            {
                var responseApi = await client.SendAsync(request);
                var contentRes = await responseApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<FaceModel>(contentRes);

                if (responseApi.IsSuccessStatusCode) {

                    response.StatusCode = responseApi.StatusCode;
                    response.DataReturn = objResponse;
                
                }
                else
                {
                    response.StatusCode = responseApi.StatusCode;
                    response.ErrorObject = JsonSerializer.Deserialize<ExpandoObject>(contentRes);
                }


            }
            return response;
           
        }
    }
}
