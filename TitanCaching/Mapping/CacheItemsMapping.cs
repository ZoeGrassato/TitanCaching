using AutoMapper;
using Services.Cache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitanCaching.Models;

namespace TitanCaching.Mapping
{
    public class CacheItemsMapping
    {
        public List<CacheItemTransferObj> MapFromCacheItems(List<CacheItem> cacheItem)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<List<CacheItem>, List<CacheItemTransferObj>>();
            });

            IMapper mapper = config.CreateMapper();
            var source = cacheItem;
            var final = mapper.Map<List<CacheItem>, List<CacheItemTransferObj>>(source);
            return final;
        }
    }
}
