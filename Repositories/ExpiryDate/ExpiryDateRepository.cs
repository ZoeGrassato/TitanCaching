using System;
using System.Collections.Generic;
using System.Text;
using Repositories.ExpiryDate.Models;

namespace Repositories.ExpiryDate
{
    public class ExpiryDateRepository : IExpiryDateRepository
    {
        public List<CacheItemExpirationAccessObj> GetAll(Guid itemId) => throw new NotImplementedException();
        public void UpdateExpiry(UpdateExpiryDateAccessObj updateExpiryItem) => throw new NotImplementedException();
    }
}
