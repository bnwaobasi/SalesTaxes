using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes.ShoppingItemTypes
{
    class ExemptItem : Item
    {
        //constructor
        public ExemptItem(string name, double price) 
        { 
            this.name = name;
            this.price = price;
            tax = CalculateSalesTax();
            isImported = false;
        }

        //Used to calculate sales tax for Exempt Item rounded up to nearest 0.05
        public override double CalculateSalesTax()
        {
            double salesTax = 0;
            return salesTax;
        }


    }
}
