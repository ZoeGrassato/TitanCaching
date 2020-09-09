using Repositories.Cache;
using Services.Cache.Models;
using Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Cache
{
    //SERVICE LAYER -> this layer handles all data preparation and work that needs to happen in order for objects to go to the REPO layer
    public class CacheService : ICacheService
    {
        private ICacheRepository _dbConnection;
        private AccessObjectMapper _accessObjectMapper = new AccessObjectMapper();
        private TransferObjectMapper _transferObjectMapper = new TransferObjectMapper();

        public CacheService(ICacheRepository cacheRepository)
        {
            _dbConnection = cacheRepository;
        }
        public void AddItem(CacheItem item)
        {
            var mapped = _accessObjectMapper.MapToAccessCacheItem(item);
            _dbConnection.AddItem(mapped);
        }
        public List<CacheItem> GetAll(string itemId = "")
        {
            var final = new List<CacheItem>();

            var unmappedItems = _dbConnection.GetAll();
            var mappedItems = _transferObjectMapper.MapToTransferCacheItems(unmappedItems);

            return final;
        }
        public void UpdateItem(UpdateCacheItem item)
        {
            var mapped = _accessObjectMapper.MapToAccessUpdateCacheItem(item);
            _dbConnection.UpdateItem(mapped);
        }
    }
}
