using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Serialization.Models
{
    public class JsonItems
    {
        public Dictionary<string, string> Items { get; set; }
        public int ItemNumber { get; set; }
    }
}
