using AutoMapper;
using Repositories.Cache.Models;
using Services.Cache.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping
{
    //this class implements all mapping that is needed for data to be passed to the repo layer
    //mapping direction API layer -> REPO layer
    public class AccessObjectMapper
    {

        public CacheItemAccessObj MapToAccessCacheItem(CacheItem cacheItem)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CacheItem, CacheItemAccessObj>();
            });

            IMapper mapper = config.CreateMapper();
            var source = cacheItem;
            var final = mapper.Map<CacheItem, CacheItemAccessObj>(source);
            return final;
        }

        public UpdateCacheItemAccessObj MapToAccessUpdateCacheItem(UpdateCacheItem cacheItem)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UpdateCacheItem, UpdateCacheItemAccessObj>();
            });

            IMapper mapper = config.CreateMapper();
            var source = cacheItem;
            var final = mapper.Map<UpdateCacheItem, UpdateCacheItemAccessObj>(source);
            return final;
        }
    }
}
