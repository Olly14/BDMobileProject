using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.Models
{
    public class ProductModel
    {
        public string ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsBlocked { get; set; }

        public virtual List<OrderItemModel> OrderItems { get; set; }

    }
}
