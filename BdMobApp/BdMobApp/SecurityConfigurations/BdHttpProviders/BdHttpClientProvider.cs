using Bd.MobileApi.Data.Management;
using BdMobApp.ModelMappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BdMobApp.ServiceConfigurtion.BdHttpVlientProvider
{
    public class BdHttpClientProvider<TEntity> : IBdHttpClientProvider<TEntity> where TEntity : class
    {

        public BdHttpClientProvider()
        {

        }

        public async  Task<IEnumerable<TEntity>> ListAsync(string path)
        {
            IEnumerable<TEntity> result = null;
            var requestPath = Path.Combine(HttpClientProvider.BaseUrl, path);
            var uri = new Uri(requestPath);
            var message = new HttpRequestMessage(HttpMethod.Get, uri);
            using (var client = HttpClientProvider.Create())
            {
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();

                    result = MapperConfig.Mapper.Map<IEnumerable<TEntity>>(JsonConvert.DeserializeObject<TEntity>(stringResult));

                    return result;
                }
                return result;
            }

        }

        public async Task<TEntity> GetAsync(string path)
        {
            var result = default(TEntity);
            var requestPath = Path.Combine(HttpClientProvider.BaseUrl, path);
            var uri = new Uri(requestPath);
            var message = new HttpRequestMessage(HttpMethod.Get, uri);
            using (var client = HttpClientProvider.Create())
            {
                var response = await client.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();

                    result = MapperConfig.Mapper.Map<TEntity>(JsonConvert.DeserializeObject<TEntity>(stringResult));

                    return result;
                }
                return result;
            }
        }

        public Task<TEntity> PutAsync(string path)
        {
            throw new NotImplementedException();
        }
    }
}
