using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes.ShoppingItemTypes
{
    class StandardItem : Item
    {
        //constructor
        public StandardItem(string name, double price)
        {
            this.name = name;
            this.price = price;
            tax = CalculateSalesTax();
            isImported = false;
        }

        //Used to calculate sales tax for Standard Item rounded up to nearest 0.05
        public override double CalculateSalesTax()
        {
            double salesTax = Math.Ceiling(price * .10 *20)/20;
            return salesTax;
        }

   

    }
}
