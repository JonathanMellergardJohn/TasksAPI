
namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters, string connectionId = "Default");
        Task<int> SaveData<T>(string sql, T parameters, string connectionId = "Default");
    }
}