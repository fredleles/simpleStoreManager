using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Events
{
    internal class ListProductsFromSaleEvent : IEvent
    {
        public int SaleId { get; private set; }

        public ListProductsFromSaleEvent(int saleId)
        {
            SaleId = saleId;
        }
    }
}
