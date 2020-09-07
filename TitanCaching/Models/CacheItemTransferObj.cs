using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitanCaching.Models
{
    public class CacheItemTransferObj
    {
        public string Key { get; set; }
        public Byte[] Value { get; set; }
    }
}
