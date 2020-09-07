using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.ExpiryDate
{
    public interface IExpiryDateRepository
    {
        /// <summary>
        /// Updates the expiratioon of an item based on an itemId
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="expirationDate"></param>
        void UpdateExpiry(Guid itemId, DateTime expirationDate);

        /// <summary>
        /// Gets all expiry date objects from the db table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemId"></param>
        /// <returns></returns>
        List<T> GetAll<T>(Guid itemId);
    }
}
