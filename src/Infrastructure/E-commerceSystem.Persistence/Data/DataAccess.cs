using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using E_commerceSystem.Persistence.Data.Impl;

namespace E_commerceSystem.Persistence.Data;
public class DataAccess : IDataAccess
{
    private readonly IConfiguration _config;
    public DataAccess(IConfiguration config)
    {
        _config = config;
    }
    public async Task<IEnumerable<T>> GetData<T, P>(string query, P parameters, string connectionID = "SQL")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));
        return await connection.QueryAsync<T>(query, parameters);
    }
    public async Task<bool> SaveData<P>(string query, P parameters, string connectionID = "SQL")
    {
        try
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));
            await connection.ExecuteAsync(query, parameters);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
