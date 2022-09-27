using ApiDataAccess.Library.Models;
using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using DesktopUI.Models;
using DesktopUI.ViewModels.Commands.SalesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ModelsMapping
{
    internal class SaleDisplayListMapping : ModelMapping<SaleModel, SaleDisplayListModel>
    {
        private readonly IEventChannel<ListProductsFromSaleEvent> _evt;
        public SaleDisplayListMapping(IEventChannel<ListProductsFromSaleEvent> evt)
        {
            _evt = evt;
        }

        protected override SaleDisplayListModel SpecificMapping(SaleModel fromObj)
        {
            SaleDisplayListModel model = new()
            {
                SaleId = fromObj.SaleId,
                User = fromObj.User,
                Date = fromObj.Date,
                Total = fromObj.Total,
                Command = new ListProductsCommand(_evt, fromObj.SaleId)
            };
            return model;
        }
    }
}
