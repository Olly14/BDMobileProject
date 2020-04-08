using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        public  ProductModel _product;

        public ProductDetailViewModel(ProductModel productModel = null)
        {
            Title = productModel?.Name;
            _product = productModel?? new ProductModel();
        }

        public string ProductModelId
        {
            get{
                return _product.ProductId;
            }
            set{
                _product.ProductId = value;
                OnPropertyChanged();
            }
        }

        public string ProductModelName {
            get {
                return _product.Name;
            }
            set {
                _product.Name = value;
                OnPropertyChanged();
            }
        }

        public string ProductModelDescription
        {
            get{
                return _product.Description;
            }
            set{
                _product.Description = value;
                OnPropertyChanged();
            }
        }

        public bool ProductModelIsBlocked
        {
            get{
                return _product.IsBlocked;
            }
            set{
                _product.IsBlocked = value;
                OnPropertyChanged();
            }
        }

        public bool ProductModelIsDeleted
        {
            get{
                return _product.IsDeleted;
            }
            set{
                _product.IsDeleted = value;
                OnPropertyChanged();
            }
        }

        public double ProductModelPrice
        {
            get{
                return _product.Price;
            }
            set{
                _product.Price = value;
                OnPropertyChanged();
            }
        }

        public List<OrderItemModel> ProductModelOrderItems
        {
            get{
                return _product.OrderItems;
            }
            set{
                _product.OrderItems = value;
                OnPropertyChanged();
            }
        }
    }
}
