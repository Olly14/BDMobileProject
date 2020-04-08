using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        private SignInModel _signInModel;

        public SignInViewModel()
        {
            _signInModel = new SignInModel();
        }

        public string Username {
            get {
                return _signInModel.Username;
            } set {
                _signInModel.Username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password {
            get{
                return _signInModel.Password;
            }
            set{
                _signInModel.Password = value;
                OnPropertyChanged("Password");
            }
        }


    }
}
