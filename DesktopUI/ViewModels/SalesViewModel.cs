using ApiDataAccess.Library.Api;
using ApiDataAccess.Library.Models;
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

        public SalesViewModel(ISaleEndpoint saleEndpoint)
        {
            _saleEndpoint = saleEndpoint;
            LoadSales();
        }

        private async void LoadSales()
        {
            try
            {
                var salesList = await _saleEndpoint.GetAll();
                Sales = new BindingList<SaleModel>(salesList);
            }
            catch
            {
                // TODO
            }
        }

        private BindingList<SaleModel>? _sales;

        public BindingList<SaleModel>? Sales
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
