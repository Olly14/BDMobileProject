using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ViewModels
{
    public class AppUserViewModel : BaseViewModel
    {
        private AppUserModel _appUserModel;
        public AppUserViewModel()
        {
            _appUserModel = new AppUserModel();
        }

        public string AppUserId {
            get{
                return _appUserModel.AppUserId;
            }
            set{
                 _appUserModel.AppUserId = value;
                OnPropertyChanged("AppUserId");
            }
        }

        public string UserName
        {
            get{
                return _appUserModel.UserName;
            }
            set{
                _appUserModel.UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string MobileNumber
        {
            get{
                return _appUserModel.MobileNumber;
            }
            set{
                _appUserModel.MobileNumber = value;
                OnPropertyChanged("MobileNumber");
            }
        }

        public string FirstLineOfAddress
        {
            get{
                return _appUserModel.FirstLineOfAddress;
            }
            set{
                _appUserModel.FirstLineOfAddress = value;
                OnPropertyChanged("FirstLineOfAddress");
            }
        }

        public string SecondLineOfAddress
        {
            get{
                return _appUserModel.SecondLineOfAddress;
            }
            set{
                _appUserModel.SecondLineOfAddress = value;
                OnPropertyChanged("SecondLineOfAddress");
            }
        }

        public string Town
        {
            get{
                return _appUserModel.Town;
            }
            set{
                _appUserModel.Town = value;
                OnPropertyChanged("Town");
            }
        }

        public string PostCode
        {
            get{
                return _appUserModel.PostCode;
            }
            set{
                _appUserModel.PostCode = value;
                OnPropertyChanged("PostCode");
            }
        }


        public string Password
        {
            get{
                return _appUserModel.Password;
            }
            set{
                _appUserModel.Password = value;
                OnPropertyChanged("Password");
            }
        }
        public string ConfirmedPassword
        {
            get{
                return _appUserModel.ConfirmedPassword;
            }
            set{
                _appUserModel.ConfirmedPassword = value;
                OnPropertyChanged("ConfirmedPassword");
            }
        }

    }
}
