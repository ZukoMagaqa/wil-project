using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp.Models
{
    public class Product
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public int Qauntity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
