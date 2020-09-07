using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.ExpiryDate.Models
{
    public class CacheItemExpirationAccessObj
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
