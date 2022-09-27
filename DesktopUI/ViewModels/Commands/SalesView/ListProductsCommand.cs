using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels.Commands.SalesView
{
    internal class ListProductsCommand : CommandBase
    {
        private int _saleId;
        public ListProductsCommand(int saleId)
        {
            _saleId = saleId;
        }
        public override void Execute(object? parameter)
        {
            
        }
    }
}
