using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTaxes.ShoppingItemTypes;

namespace SalesTaxes.ReceiptGenerator
{
    class Receipt
    {
        public List<Item> items { get; set; }
        public double totalSalesTax { get; set; }
        public double total { get; set; }

    }
}
