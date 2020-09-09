using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ExpiryDate.Models
{
    public class CacheItemExpirationDate
    {
        public string Key { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
