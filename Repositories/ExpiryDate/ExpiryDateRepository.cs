using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.ExpiryDate
{
    public class ExpiryDateRepository : IExpiryDateRepository
    {
        public List<T> GetAll<T>(Guid itemId) => throw new NotImplementedException();
        public void UpdateExpiry(Guid itemId, DateTime expirationDate) => throw new NotImplementedException();
    }
}
