using BackendlessAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp.Models
{
    public class Seller: BackendlessUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string MyPassword { get; set; }
        public string Role { get; set; }
    }
}
