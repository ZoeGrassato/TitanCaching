using Microsoft.Extensions.DependencyInjection;
using Repositories.Cache;
using Services.Cache;
using Services.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanCaching.DependancyInjenction
{
    public static class DependancyInjenctionRegistration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ICacheService, CacheService>();
            services.AddTransient<ICacheRepository, CacheRepository>();
            services.AddTransient<ISerializationManager, SerializationManager>();
        }
    }
}
