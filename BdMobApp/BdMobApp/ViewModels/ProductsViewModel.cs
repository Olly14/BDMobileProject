using Bd.MobileApi.Data.Management;
using Bd.MobileApi.Data.Management.DtoModels;
using BdMobApp.ModelMappers;
using BdMobApp.Models;
using BdMobApp.ServiceConfigurtion.BdHttpVlientProvider;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BdMobApp.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        private IBdHttpClientProvider<ProductDto> _bdHttpClientProvider;

        public ProductsViewModel()
        {
            ObservableProducts = new ObservableCollection<ProductModel>();
            _bdHttpClientProvider = HttpClientProduct;
            LoadProductsCommand = new Command(async () => await ExecuteLoadProductsAsync());
         }

        public ObservableCollection<ProductModel> ObservableProducts { get; set; }
        //public ObservableCollection<ProductModel> Products { get; set; }
        public Command LoadProductsCommand { get; set; }



        //private async Task<ObservableCollection<ProductModel>> ExecuteLoadProductsAsync()
        private async Task<ObservableCollection<ProductModel>> ExecuteLoadProductsAsync()
        {
            //Products = new ObservableCollection<ProductModel>();
            if (IsBusy)
            {
                return ObservableProducts;
            }
            IsBusy = true;
            try
            {

                ObservableProducts.Clear();
                var products = MapperConfig.Mapper
                    .Map<IEnumerable<ProductModel>>(
                    await ProductClient.FindProductsAsync());

                foreach (var item in products)
                {
                    ObservableProducts.Add(item);
                }
                //var productsSize = products.Count();
                //for (int i = 0; i < productsSize; i++)
                //{
                //    var prod = products[i];
                //    Products.Add(prod);
                //}
                return ObservableProducts;
                //Products = products.ToList().Select(p => { Products.Add(p); return p; }); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally{
                IsBusy = false;
            }
        }



    }
}
