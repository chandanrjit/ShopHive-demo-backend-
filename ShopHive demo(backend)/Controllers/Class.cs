using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ShopHive_demo_backend_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : ControllerBase
    
        private const string ShophiveApiEndpoint = "https://www.shophive.com/magebig_ajaxsearch/ajax/index/?q={0}";

        [HttpGet("{query}")]
        public async Task<IEnumerable<Model.Product>> Search(string query)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = string.Format(ShophiveApiEndpoint, query);
                var response = await httpClient.GetAsync(apiUrl);
                var content = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<IEnumerable<Model.Product>>(content);
                return products;
            }
        }
    }
}
