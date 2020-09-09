using Services.Cache.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Cache
{
    public interface ICacheService
    {
        /// <summary>
        /// Forwards an item to the repo layer in order to add it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void AddItem(CacheItem item);

        /// <summary>
        /// updates a serialized item then forwards it to the repo layer in the correct form
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">the item to update</param>
        /// <param name="itemId">the itemId of the item that needs to be updated</param>
        void UpdateItem(UpdateCacheItem item);

        /// <summary>
        /// Gets all items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemId"></param>
        /// <returns></returns>
        List<CacheItem> GetAll(Guid itemId = default(Guid));
    }
}
