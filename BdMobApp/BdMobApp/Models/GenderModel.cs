using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.Models
{
    public class GenderModel
    {
        public string GenderId { get; set; }
        public string Type { get; set; }

        //Navigation property
        public virtual IEnumerable<AppUserModel> AppUsers { get; set; }
    }
}
