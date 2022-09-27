using SQLData.Library.Models;

namespace SQLData.Library.DataAccess
{
    public interface ISaleData
    {
        List<SaleModel> GetSales();
    }
}