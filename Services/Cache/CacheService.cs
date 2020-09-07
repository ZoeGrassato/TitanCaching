using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Cache
{
    public class CacheService : ICacheService
    {
        public void AddItem<T>(T item) => throw new NotImplementedException();
        public List<T> GetAll<T>(Guid itemId) => throw new NotImplementedException();
        public void UpdateItem<T>(T item, Guid itemId) => throw new NotImplementedException();
    }
}
