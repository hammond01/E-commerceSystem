namespace E_commerceSystem.Persistence.Data.Impl;
public interface IDataAccess
{
    Task<IEnumerable<T>> GetData<T, P>(string query, P parameters, string connectionID = "SQL");
    Task<bool> SaveData<P>(string query, P parameters, string connectionID = "SQL");
}
