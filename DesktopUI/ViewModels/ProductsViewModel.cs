using ApiDataAccess.Library.Api;
using DesktopUI.Helpers.ModelsMapping;
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
        private readonly ProductDisplayListMapping _mapping;
        public ProductsViewModel(IProductEndpoint productEndpoint, ProductDisplayListMapping mapping)
        {
            _productEndpoint = productEndpoint;
            _mapping = mapping;
            LoadProducts();
        }

        private async void LoadProducts()
        {
            try
            {
                var productList = await _productEndpoint.GetAll();
                var products = _mapping.CreateMap(productList);
                Products = new BindingList<ProductDisplayListModel>(products);
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
