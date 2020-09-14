using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Text;
using Repositories.Exceptions;
using Repositories.ExpiryDate.Models;

namespace Repositories.ExpiryDate
{
    public class ExpiryDateRepository : IExpiryDateRepository
    {
        private string _connectionString;
        public List<CacheItemExpirationAccessObj> GetAll(Guid itemId)
        {
            string sqlQuery = "SELECT * FROM dbo.CacheItems_Expiry";
            var cacheItems = new List<CacheItemExpirationAccessObj>();

            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    cacheItems = (List<CacheItemExpirationAccessObj>)connection.Query<CacheItemExpirationAccessObj>(sqlQuery);
                }
                catch (Exception ex)
                {
                    throw new GeneralDatabaseException("A Db related error occured when trying to run your query", ex);
                }
            }
            return cacheItems;
        }
        public void UpdateExpiry(UpdateExpiryDateAccessObj updateExpiryItem)
        {
            string sqlQuery = "UPDATE dbo.CacheItems SET value = @ExpiryDate WHERE ExpiryDate = @ExpiryDate WHERE key = @key";
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var affectedRows = connection.Execute(sqlQuery, new
                    {
                        ExpiryDate = updateExpiryItem.ExpiryDate,
                        Key = updateExpiryItem.Key
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
