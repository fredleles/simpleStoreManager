using ApiDataAccess.Library.Models;
using DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ModelsMapping
{
    internal class SaleDisplayListMapping : ModelMapping<SaleModel, SaleDisplayListModel>
    {
        protected override SaleDisplayListModel SpecificMapping(SaleModel fromObj)
        {
            SaleDisplayListModel model = new()
            {
                SaleId = fromObj.SaleId,
                User = fromObj.User,
                Date = fromObj.Date,
                Total = fromObj.Total,
                Command = new(fromObj.SaleId)
            };
            return model;
        }
    }
}
