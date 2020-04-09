using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BdMobApp.ServiceConfigurtion.BdHttpVlientProvider
{
    public interface IBdHttpClientProvider<TEntity> where TEntity : class 
    {
        Task<TEntity> GetAsync(string path);

        Task<IEnumerable<TEntity>> ListAsync(string path);

        Task<TEntity> PutAsync(string path);


    }
}
