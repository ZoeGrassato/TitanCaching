using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Serialization.Models
{
    public class ViewJsonDataProperties
    {
        public List<string> Items { get; set; }
        public int TotalCountOfItems { get; set; }
    }
}
