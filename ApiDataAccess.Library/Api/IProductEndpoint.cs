using ApiDataAccess.Library.Models;

namespace ApiDataAccess.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}