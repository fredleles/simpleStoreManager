using SQLData.Library.Models;

namespace SQLData.Library.DataAccess
{
    public interface ISaleData
    {
        List<SaleProductModel> GetProductsBySaleId(int SaleId);
        List<SaleModel> GetSales();
    }
}