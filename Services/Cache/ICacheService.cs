﻿using System;
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
        void AddItem<T>(T item);

        /// <summary>
        /// updates a serialized item then forwards it to the repo layer in the correct form
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">the item to update</param>
        /// <param name="itemId">the itemId of the item that needs to be updated</param>
        void UpdateItem<T>(T item, Guid itemId);

        /// <summary>
        /// Gets all items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemId"></param>
        /// <returns></returns>
        List<T> GetAll<T>(Guid itemId);
    }
}
