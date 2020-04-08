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
    public partial class SignInPage : ContentPage
    {
        private SignInViewModel _signInViewModel;
        public SignInPage()
        {
            InitializeComponent();
            _signInViewModel = new SignInViewModel();
            this.BindingContext = _signInViewModel;
        }
    }
}