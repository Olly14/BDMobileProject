using Bd.MobileApi.Data.Management.DtoModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bd.MobileApi.Data.Management.Services.ProductServices
{
    public interface IProductClient
    {
        Task<IEnumerable<ProductDto>> FindProductsAsync();

        Task<ProductDto> FindProductAsync(string id);
    }
}
