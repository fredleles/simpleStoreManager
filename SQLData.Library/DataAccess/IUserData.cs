using SQLData.Library.Models;

namespace SQLData.Library.DataAccess
{
    public interface IUserData
    {
        List<UserModel> GetAll();
        List<UserModel> GetUserById(string Id);
        string VerifyLogin(string username, string password);
    }
}