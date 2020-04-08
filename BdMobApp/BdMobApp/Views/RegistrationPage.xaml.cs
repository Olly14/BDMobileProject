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
    public partial class RegistrationPage : ContentPage
    {
        private AppUserViewModel _appUserViewModel; 

        public RegistrationPage()
        {
            InitializeComponent();
            _appUserViewModel = new AppUserViewModel();
            this.BindingContext = _appUserViewModel;
        }
    }
}