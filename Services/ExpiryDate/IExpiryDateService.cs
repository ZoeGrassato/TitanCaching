using Repositories.ExpiryDate.Models;
using Services.ExpiryDate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ExpiryDate
{
    public interface IExpiryDateService
    {
        void UpdateExpiryDate(UpdateExpiryDate expiryDate);
        List<CacheItemExpirationDate> GetAllExpiryDateItems();
    }
}
