using Repositories.ExpiryDate.Models;
using Services.ExpiryDate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ExpiryDate
{
    public class ExpiryDateService : IExpiryDateService
    {
        public List<CacheItemExpirationDate> GetAllExpiryDateItems()
        {
            var final = new List<CacheItemExpirationDate>();
            return final;
        }

        public void UpdateExpiryDate(UpdateExpiryDate expiryDate)
        {

        }
    }
}
