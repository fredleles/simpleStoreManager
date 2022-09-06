namespace SQLData.Library.DataAccess
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string storedProcedure, U parameters);
    }
}