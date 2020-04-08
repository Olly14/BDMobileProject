using Bd.MobileApi.Data.Management.DtoModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bd.MobileApi.Data.Management.Services.AppUserServices
{
    public class AppUserClient : IAppUserClient
    {
        public async Task<IEnumerable<AppUserDto>> FindAllAppUsersAsync()
        {
            var appUsers = new List<AppUserDto>();
            var path = Path.Combine(HttpClientProvider.BaseUrl, HttpClientProvider.AppUsersUrl);
            var uri = new Uri(path);
            var client = new HttpClient();
            client.BaseAddress = uri;
            HttpResponseMessage response = await Task.Run(() => client.GetAsync(uri));

            if (response.IsSuccessStatusCode)
            {
                var appUsersString = await response.Content.ReadAsStringAsync();

                appUsers = JsonConvert.DeserializeObject<IEnumerable<AppUserDto>>(appUsersString).ToList();
            }
            return appUsers;
        }

        public async Task<AppUserDto> FindAppUserAsync(string id)
        {
            var appUser = new AppUserDto();
            var path = Path.Combine(HttpClientProvider.BaseUrl, HttpClientProvider.AppUsersUrl, "/" ,id);
            var uri = new Uri(path);
            var client = new HttpClient();
            client.BaseAddress = uri;
            HttpResponseMessage response = await Task.Run(() => client.GetAsync(uri));

            if (response.IsSuccessStatusCode)
            {
                var appUsersString = await response.Content.ReadAsStringAsync();

                appUser = JsonConvert.DeserializeObject<AppUserDto>(appUsersString);
            }
            return appUser;
        }
    }
}
