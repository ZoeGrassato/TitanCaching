
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Cache.Models
{
    public class UpdateCacheItemAccessObj
    {
        public string Key { get; set; }
        public Byte[] Value { get; set; }
    }
}
