using System;
using System.Collections.Generic;
using System.Text;

namespace Bd.MobileApi.Data.Management.DtoModels
{
    public class GenderDto
    {
        public string GenderId { get; set; }
        public string Type { get; set; }

        //Navigation property
        public virtual IEnumerable<AppUserDto> AppUsers { get; set; }
    }
}
