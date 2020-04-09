using Acr.UserDialogs;
using System;
using System.Threading.Tasks;

namespace BdMobApp.ViewModelServices
{
    class ConfirmationService : IConfirmationService
    {
        public async Task<bool> AskConfirmationAsync(string message)
        {
            var config = new ConfirmConfig() { 
                Title = "Confirmation",
                Message = message,
                OkText = "Yes",
                CancelText = "No"
            
            };

            return await UserDialogs.Instance.ConfirmAsync(config);
        }
    }
}
