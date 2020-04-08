using BdMobApp.Models;
using BdMobApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BdMobApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        private ProductsViewModel _productsViewModel;

        public ProductsPage()
        {
            InitializeComponent();
            BindingContext = _productsViewModel = new ProductsViewModel();
        }

        async void OnSelectedItem(object sender, SelectedItemChangedEventArgs args)
        {
            //var layout = (BindableObject)sender;
            //var item = (ProductModel)layout.BindingContext;
            var productSelected = args.SelectedItem as ProductModel;
            if (productSelected == null)
            {
                return;
            }
            await Navigation.PushAsync(new ProductDetailPage(new ProductDetailViewModel(productSelected)));
            //await Navigation.PushAsync(new ProductDetailPage(new ProductDetailViewModel(item)));

            ProductsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (_productsViewModel.Products.Count == 0){
                _productsViewModel.LoadProductsCommand.Execute(null);
            }

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var layout = (BindableObject)sender;
            var item = (ProductModel)layout.BindingContext;
            //var productSelected = e.SelectedItem as ProductModel;
            //if (productSelected == null)
            //{
            //    return;
            //}
            //await Navigation.PushAsync(new ProductDetailPage(new ProductDetailViewModel(productSelected)));
            await Navigation.PushAsync(new ProductDetailPage(new ProductDetailViewModel(item)));

            ProductsListView.SelectedItem = null;
        }
    }
}