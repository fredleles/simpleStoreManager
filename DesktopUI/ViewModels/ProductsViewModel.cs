using ApiDataAccess.Library.Models;
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
        public ProductsViewModel()
        {
            _products.Add(new ProductDisplayListModel()
            {
                Id = 1,
                ProductName = "Produto1",
                Barcode = "123445",
                QuantityInStock = 10,
                RetailPrice = 9.90m,
            });
            _products.Add(new ProductDisplayListModel()
            {
                Id = 2,
                ProductName = "Produto2",
                Barcode = "123445",
                QuantityInStock = 1,
                RetailPrice = 99.90m,
            });
        }

        private BindingList<ProductDisplayListModel> _products = new();
        public BindingList<ProductDisplayListModel> Products
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
