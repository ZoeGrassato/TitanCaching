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
        void AddItem<T>(T item);

        /// <summary>
        /// Inserts an updated serialized item back into the db table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">the item to update</param>
        /// <param name="itemId">the itemId of the item that needs to be updated</param>
        void UpdateItem<T>(T item, Guid itemId);

        /// <summary>
        /// Gets all items from the db table, filterable based on an id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemId"></param>
        /// <returns></returns>
        List<T> GetAll<T>(Guid itemId);
    }
}
