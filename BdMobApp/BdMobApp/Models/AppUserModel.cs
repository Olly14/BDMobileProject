using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.Models
{
    public class AppUserModel
    {
        public string AppUserId { get; set; }

        public string UserName { get; set; }

        public string MobileNumber { get; set; }

        public string FirstLineOfAddress { get; set; }

        public string SecondLineOfAddress { get; set; }

        public string Town { get; set; }

        public string Password { get; set; }

        public string ConfirmedPassword { get; set; }

        public string PostCode { get; set; }
    }
}
