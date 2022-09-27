using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Library.Models
{
    public class SaleModel
    {
        public int SaleId { get; set; }
        public string User { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}
