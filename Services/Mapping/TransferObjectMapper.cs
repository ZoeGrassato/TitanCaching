using AutoMapper;
using Repositories.Cache.Models;
using Services.Cache.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping
{
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
    }
}
