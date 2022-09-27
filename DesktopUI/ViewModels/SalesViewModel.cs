using ApiDataAccess.Library.Api;
using ApiDataAccess.Library.Models;
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
    internal class SalesViewModel : ViewModelBase
    {
        private readonly ISaleEndpoint _saleEndpoint;
        private readonly SaleDisplayListMapping _mapping;

        public SalesViewModel(ISaleEndpoint saleEndpoint, SaleDisplayListMapping mapping)
        {
            _saleEndpoint = saleEndpoint;
            _mapping = mapping;
            LoadSales();
        }

        private async void LoadSales()
        {
            try
            {
                var salesList = await _saleEndpoint.GetAll();
                var sales = _mapping.CreateMap(salesList);
                Sales = new BindingList<SaleDisplayListModel>(sales);
            }
            catch
            {
                // TODO
            }
        }

        private BindingList<SaleDisplayListModel>? _sales;

        public BindingList<SaleDisplayListModel>? Sales
        {
            get { return _sales; }
            set
            {
                _sales = value;
                OnPropertyChanged(nameof(Sales));
            }
        }

        private BindingList<SaleProductModel>? _saleProducts;

        public BindingList<SaleProductModel>? SaleProducts
        {
            get { return _saleProducts; }
            set
            {
                _saleProducts = value;
                OnPropertyChanged(nameof(SaleProducts));
            }
        }


    }
}
