using System;
using System.Collections.Generic;

namespace BdMobApp.Models
{
    public class OrderModel
    {
        public string OrderId { get; set; }

        public string AppUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }

        public double TotalPrice { get; set; }

        public virtual List<OrderItemModel> OrderItems { get; set; }
        public AppUserModel AppUser { get; set; }

    }
}