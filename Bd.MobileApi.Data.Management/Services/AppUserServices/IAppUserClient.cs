using Bd.MobileApi.Data.Management.DtoModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bd.MobileApi.Data.Management.Services.AppUserServices
{
    public interface IAppUserClient
    {
        Task<IEnumerable<AppUserDto>> FindAllAppUsersAsync();

        Task<AppUserDto> FindAppUserAsync(string id);
    }
}
