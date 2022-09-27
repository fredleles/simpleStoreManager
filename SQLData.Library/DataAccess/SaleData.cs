using SQLData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Library.DataAccess
{
    public class SaleData : ISaleData
    {
        private readonly ISqlDataAccess _sql;

        public SaleData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<SaleModel> GetSales()
        {
            var output = _sql.LoadData<SaleModel, dynamic>("spSaleGetAll", new { });
            return output;
        }

        public List<SaleProductModel> GetProductsBySaleId(int SaleId)
        {
            var output = _sql.LoadData<SaleProductModel, dynamic>("spProductSaleGetById", new { SaleId });
            return output;
        }
    }
}
