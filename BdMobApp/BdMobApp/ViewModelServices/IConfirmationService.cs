using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BdMobApp.ViewModelServices
{
    public interface IConfirmationService
    {
        Task<bool> AskConfirmationAsync(string message);
    }
}
