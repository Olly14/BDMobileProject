using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        SignIn,
        SignOut,
        Registration,
        Complaint,
        Rate
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
