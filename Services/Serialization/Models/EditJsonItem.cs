using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Serialization.Models
{
    public class EditJsonItem
    {
        public IEnumerable<JsonItem> Items { get; set; }
        public int CacheItemNumber { get; set; }
        public string CacheKey { get; set; }
        public int JsonPropCount { get; set; }
    }
}
