using ApiDataAccess.Library.Models;

namespace ApiDataAccess.Library.Api
{
    public interface ISaleEndpoint
    {
        Task<List<SaleModel>> GetAll();
        Task<List<SaleProductModel>> GetProductsFromSaleId(int SaleId);
    }
}