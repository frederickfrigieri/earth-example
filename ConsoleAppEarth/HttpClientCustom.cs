using System;
using System.Net.Http;
using System.Text.Json;

namespace ConsoleAppEarth
{
    public class HttpClientCustom
    {
        private readonly HttpClient client;
        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public HttpClientCustom()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("https://earth2stats.net/api/")
            };
        }

        public object GetExample<T>(string endpoint) where T : class
        {
            var response = client.GetAsync($"{endpoint}").Result;

            return JsonSerializer.Deserialize<T>(response.Content.ReadAsStringAsync().Result, _options);
        }
    }
}
