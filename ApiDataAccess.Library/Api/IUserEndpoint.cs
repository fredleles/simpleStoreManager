using ApiDataAccess.Library.Models;

namespace ApiDataAccess.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
    }
}