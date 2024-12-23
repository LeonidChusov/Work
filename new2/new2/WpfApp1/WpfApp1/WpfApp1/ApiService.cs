using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.House;

namespace WpfApp1
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            return JsonConvert.DeserializeObject<List<User>>(response);
        }
    }
}
