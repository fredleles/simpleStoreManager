using DesktopUI.ViewModels.Commands.SalesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Models
{
    internal class SaleDisplayListModel
    {
        public int SaleId { get; set; }
        public string User { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public ListProductsCommand? Command { get; set; }
    }
}
