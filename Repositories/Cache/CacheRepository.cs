using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Cache
{
    public class CacheRepository : ICacheRepository
    {
        public void AddItem<T>(T item) => throw new NotImplementedException();
        public List<T> GetAll<T>(Guid itemId) => throw new NotImplementedException();
        public void UpdateItem<T>(T item, Guid itemId) => throw new NotImplementedException();
    }
}
