using DesktopUI.Events;
using DesktopUI.Helpers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels.Commands.SalesView
{
    internal class ListProductsCommand : CommandBase
    {
        private readonly IEventChannel<ListProductsFromSaleEvent> _evt;
        private int _saleId;
        public ListProductsCommand(IEventChannel<ListProductsFromSaleEvent> evt, int saleId)
        {
            _evt = evt;
            _saleId = saleId;
        }
        public override void Execute(object? parameter)
        {
            _evt.PublishEvent(new ListProductsFromSaleEvent(_saleId));
        }
    }
}
