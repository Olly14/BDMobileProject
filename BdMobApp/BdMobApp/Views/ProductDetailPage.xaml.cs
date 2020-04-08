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
    public partial class ProductDetailPage : ContentPage
    {
        ProductDetailViewModel _productViewModel;

        public ProductDetailPage(ProductDetailViewModel productViewModel)
        {
            InitializeComponent();

            _productViewModel = productViewModel;

            BindingContext = _productViewModel;
        }

        public ProductDetailPage()
        {
            InitializeComponent();

            _productViewModel = new ProductDetailViewModel();

            BindingContext = _productViewModel;
        }
    }
}