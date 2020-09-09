using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.ExpiryDate.Models
{
    public class UpdateExpiryDateAccessObj
    {
        public string Key { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
