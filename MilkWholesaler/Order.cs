using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkWholesaler
{
    internal class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int SupplierID { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
