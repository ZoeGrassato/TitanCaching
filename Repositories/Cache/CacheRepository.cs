using Dapper;
using Npgsql;
using Repositories.Cache.Models;
using Repositories.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repositories.Cache
{
    //REPOSITORY LAYER -> This handles all db related interaction for CacheItems
    public class CacheRepository : ICacheRepository
    {
        private string _connectionString;
        public CacheRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void AddItem(CacheItemAccessObj item)
        {
            string sqlQuery = "INSERT INTO dbo.CacheItems(Key, Value) VALUES(@Key, @Value)";
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var affectedRows = connection.Execute(sqlQuery, new
                    {
                        Key = item.Key,
                        Value = item.Value
                    });
                }
                catch (Exception ex)
                {
                    throw new GeneralDatabaseException("A Db related error occured when trying to run your query", ex);
                }
            }
        }
        public List<CacheItemAccessObj> GetAll(string itemId = "")
        {
            string sqlQuery = "SELECT * FROM dbo.CacheItems";
            var cacheItems = new List<CacheItemAccessObj>();

            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    cacheItems = (List<CacheItemAccessObj>)connection.Query<CacheItemAccessObj>(sqlQuery);
                }
                catch (Exception ex)
                {
                    throw new GeneralDatabaseException("A Db related error occured when trying to run your query", ex);
                }
            }
            return cacheItems;
        }
        public void UpdateItem(UpdateCacheItemAccessObj item)
        {
            string sqlQuery = "UPDATE dbo.CacheItems SET key = @Key, value = @Value WHERE key = @OldKey";
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var affectedRows = connection.Execute(sqlQuery, new
                    {
                        OldKey = item.OldKey,
                        Key = item.Key,
                        Value = item.Value
                    });
                }
                catch (Exception ex)
                {
                    throw new GeneralDatabaseException("A Db related error occured when trying to run your query", ex);
                }
            }
        }

        public void UpdateBytesValue(UpdateCacheItemAccessObj item)
        {
            string sqlQuery = "UPDATE dbo.CacheItems SET value = @Value WHERE key = @Key";
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var affectedRows = connection.Execute(sqlQuery, new
                    {
                        Key = item.Key,
                        Value = item.Value
                    });
                }
                catch (Exception ex)
                {
                    throw new GeneralDatabaseException("A Db related error occured when trying to run your query", ex);
                }
            }
        }
    }
}
