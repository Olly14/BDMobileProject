using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        private OrderModel _orderModel;

        public OrderViewModel()
        {
            _orderModel = new OrderModel();
        }

        public OrderViewModel(OrderModel orderModel)
        {
            _orderModel = orderModel;
        }
    }
}
