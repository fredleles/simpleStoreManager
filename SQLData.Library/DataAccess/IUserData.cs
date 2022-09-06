namespace SQLData.Library.DataAccess
{
    public interface IUserData
    {
        Task<bool> VerifyLogin(string username, string password);
    }
}