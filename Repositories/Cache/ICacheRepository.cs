using Repositories.Cache.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Cache
{
    public interface ICacheRepository
    {
        /// <summary>
        /// Add an item into the db table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void AddItem(CacheItemAccessObj item);

        /// <summary>
        /// Inserts an updated serialized item back into the db table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">the item to update</param>
        /// <param name="itemId">the itemId of the item that needs to be updated</param>
        void UpdateItem(UpdateCacheItemAccessObj item);

        /// <summary>
        /// Gets all items from the db table, filterable based on an id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemId"></param>
        /// <returns></returns>
        List<CacheItemAccessObj> GetAll(string itemId = "");

        /// <summary>
        /// This is used to update/edit the byte code of serialized json and put it back into the db table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="bytes"></param>
        void UpdateBytesValue(UpdateCacheItemAccessObj item);
    }
}
