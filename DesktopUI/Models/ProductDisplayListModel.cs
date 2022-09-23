using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Models
{
    internal class ProductDisplayListModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public decimal RetailPrice { get; set; }
        public int QuantityInStock { get; set; }
    }
}
