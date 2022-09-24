using SQLData.Library.Models;

namespace SQLData.Library.DataAccess
{
    public interface IProductData
    {
        List<ProductModel> GetProducts();
    }
}