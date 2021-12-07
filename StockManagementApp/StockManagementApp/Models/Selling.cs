using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp.Models
{
    public class Selling : Product
    {
        public string productId { get; set; }
        public double Total { get; set; }
    }
}
