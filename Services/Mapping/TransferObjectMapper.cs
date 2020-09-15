using AutoMapper;
using Repositories.Cache.Models;
using Repositories.ExpiryDate.Models;
using Services.Cache.Models;
using Services.ExpiryDate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping
{
    //this class implements all mapping that is needed for data to be passed to the API layer
    //mapping direction REPO Layer -> API Layer
    public class TransferObjectMapper
    {
        public List<CacheItem> MapToTransferCacheItems(List<CacheItemAccessObj> cacheItem)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<List<CacheItemAccessObj>, List<CacheItem>>();
            });

            IMapper mapper = config.CreateMapper();
            var source = cacheItem;
            var final = mapper.Map<List<CacheItemAccessObj>, List<CacheItem>>(source);
            return final;
        }

        public List<CacheItemExpirationDate> MapToTransferExpiryCacheItems(List<CacheItemExpirationAccessObj> cacheItem)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<List<CacheItemExpirationAccessObj>, List<CacheItemExpirationDate>>();
            });

            IMapper mapper = config.CreateMapper();
            var source = cacheItem;
            var final = mapper.Map<List<CacheItemExpirationAccessObj>, List<CacheItemExpirationDate>>(source);
            return final;
        }
    }
}
