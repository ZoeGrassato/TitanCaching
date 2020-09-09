using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ExpiryDate.Models
{
    public class UpdateExpiryDate
    {
        public string Key { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
