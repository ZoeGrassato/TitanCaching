using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Cache.Models
{
    public class UpdateCacheItem
    {
        public string Key { get; set; }
        public Byte[] Value { get; set; }
    }
}
