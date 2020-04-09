using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using BdMobApp.Models;
using BdMobApp.Services;
using Bd.MobileApi.Data.Management.DtoModels;
using System.Threading.Tasks;
using BdMobApp.ViewModelServices;
using Bd.MobileApi.Data.Management.Services.AppUserServices;
using Bd.MobileApi.Data.Management.Services.ProductServices;
using BdMobApp.ServiceConfigurtion.BdHttpVlientProvider;

namespace BdMobApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public IAppUserClient AppUserClient => DependencyService.Get<IAppUserClient>() ?? new AppUserClient();

        public IProductClient ProductClient => DependencyService.Get<IProductClient>() ?? new ProductClient();

        public IBdHttpClientProvider<AppUserDto> HttpClientAppUser => DependencyService.Get<IBdHttpClientProvider<AppUserDto>>() ?? new BdHttpClientProvider<AppUserDto>();

        public IBdHttpClientProvider<ProductDto> HttpClientProduct => DependencyService.Get<IBdHttpClientProvider<ProductDto>>() ?? new BdHttpClientProvider<ProductDto>();

        public IConfirmationService ConfirmationService => DependencyService.Get<IConfirmationService>() ?? new ConfirmationService();


        public Command LoadAppUser => new Command(async()=> await ExcuteLoadAppUsersAsync());

        public Command LoadProducts => new Command(async () => await ExcuteLoadProductsAsync());

        private async Task<IEnumerable<ProductDto>> ExcuteLoadProductsAsync()
        {
            var result = await ProductClient.FindProductsAsync();
            return result;
        }

        private async Task<IEnumerable<AppUserDto>> ExcuteLoadAppUsersAsync()
        {
            var result = await AppUserClient.FindAllAppUsersAsync();
            return result;
        }

        bool isBusy = false;

        public bool ButtonIsVisible = false;

        public Command ExcecuteConfirmationServiceCommand;

        

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
