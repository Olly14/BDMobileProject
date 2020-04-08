using Bd.MobileApi.Data.Management.DtoModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Bd.MobileApi.Data.Management.Services.ProductServices
{
    public class ProductClient : IProductClient
    {
        public async Task<ProductDto> FindProductAsync(string id)
        {
            var product = new ProductDto();
            var path = Path.Combine(HttpClientProvider.BaseUrl, HttpClientProvider.ProductUrl, "/", id);
            var uri = new Uri(path);
            var client = new HttpClient(new HttpClientHandler());
            client.BaseAddress = uri;
            HttpResponseMessage response = await Task.Run(() => client.GetAsync(uri));

            if (response.IsSuccessStatusCode)
            {
                var appUsersString = await response.Content.ReadAsStringAsync();

                product = JsonConvert.DeserializeObject<ProductDto>(appUsersString);
            }
            return product;
        }

        public async Task<IEnumerable<ProductDto>> FindProductsAsync()
        {
            var products = new List<ProductDto>();
            var path = Path.Combine(@"https://10.0.2.2:44301/api/", "Products");
            var uri = new Uri(path);
            var client = new HttpClient();
            //specify to use TLS 1.2 as default connection
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var appUsersString = await response.Content.ReadAsStringAsync();

                    products = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(appUsersString).ToList();
                }
                return products;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
