using BdMobApp.ModelMappers;
using BdMobApp.Models;
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

        public ProductsViewModel()
        {
            Products = new ObservableCollection<ProductModel>();
            LoadProductsCommand = new Command(async () => await ExecuteLoadProductsAsync());
        }

        public ObservableCollection<ProductModel> Products { get; set; }
        public Command LoadProductsCommand { get; set; }

       

        private async Task<ObservableCollection<ProductModel>> ExecuteLoadProductsAsync()
        {
            Products = new ObservableCollection<ProductModel>();
            if (IsBusy)
            {
                return Products;
            }
            IsBusy = true;
            try
            {
                Products.Clear();
                var products = MapperConfig.Mapper
                    .Map<IEnumerable<ProductModel>>(
                    await ProductClient.FindProductsAsync()).ToList();
                var productsSize = products.Count();
                for (int i = 0; i < productsSize; i++)
                {
                    Products.Add(products[i]);
                }
                return Products;
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
