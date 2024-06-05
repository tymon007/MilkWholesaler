using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkWholesaler
{
    internal class OrderItem
    {
        public int ProductID { get; set; }
        public int OfferID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
