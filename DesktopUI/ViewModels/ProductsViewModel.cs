using ApiDataAccess.Library.Api;
using ApiDataAccess.Library.Models;
using DesktopUI.Helpers;
using DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels
{
    internal class ProductsViewModel : ViewModelBase
    {
        private readonly IProductEndpoint _productEndpoint;
        public ProductsViewModel(IProductEndpoint productEndpoint)
        {
            _productEndpoint = productEndpoint;
            LoadProducts();
        }

        private async void LoadProducts()
        {
            try
            {
                var productList = await _productEndpoint.GetAll();
                var produtos = ModelMapping.MapList<ProductModel, ProductDisplayListModel>(productList);
                Products = new BindingList<ProductDisplayListModel>(produtos);
            }
            catch
            {
                // caso nao autorizado
            }
        }


        private BindingList<ProductDisplayListModel>? _products;
        public BindingList<ProductDisplayListModel>? Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

    }
}
