using ApiDataAccess.Library.Models;
using DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ModelsMapping
{
    internal class ProductDisplayListMapping : ModelMapping<ProductModel, ProductDisplayListModel>
    {
        protected override ProductDisplayListModel SpecificMapping(ProductModel fromObj)
        {
            ProductDisplayListModel model = new()
            {
                Id = fromObj.Id,
                ProductName = fromObj.ProductName,
                Barcode = fromObj.Barcode,
                RetailPrice = fromObj.RetailPrice,
                QuantityInStock = fromObj.QuantityInStock,
            };
            return model;
        }
    }
}
