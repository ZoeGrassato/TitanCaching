using Repositories.Cache;
using Services.Cache.Models;
using Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Cache
{
    public class CacheService : ICacheService
    {
        private CacheRepository _dbConnection = new CacheRepository("");
        private AccessObjectMapper _accessObjectMapper = new AccessObjectMapper();
        public void AddItem(CacheItem item)
        {
            var mapped = _accessObjectMapper.MapToAccessCacheItem(item);
            _dbConnection.AddItem(mapped);
        }
        public List<CacheItem> GetAll(Guid itemId)
        {
            var final = new List<CacheItem>();
            final = _dbConnection.GetAll(Guid.Empty);

            return final;
        }
        public void UpdateItem(UpdateCacheItem item)
        {
            var mapped = _accessObjectMapper.MapToAccessUpdateCacheItem(item);
            _dbConnection.UpdateItem(mapped);
        }
    }
}
