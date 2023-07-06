using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes.ShoppingItemTypes
{
    public abstract class Item
    {
        public string? name;
        public double price;
        public int quantity;
        public double tax;
        public bool isImported;

        //each type of item will have sales tax defined in own inherited method
        public abstract double CalculateSalesTax();

    }
}
