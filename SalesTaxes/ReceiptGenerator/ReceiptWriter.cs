using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTaxes.ShoppingItemTypes;

namespace SalesTaxes.ReceiptGenerator
{
    class ReceiptWriter
    {
        //Method used to precalculate receipt prices and tax before being passed to the printer
        public Receipt CreateReceipt(List<Item> items)
        {
            Receipt receipt = new Receipt();
            receipt.items = items;
            receipt.totalSalesTax = 0;
            receipt.total = 0;

            //Used to keep track of Item quantities
            var itemQuantities = new Dictionary<string, int>();

            foreach (var item in items)
            {
                //Check if the item is already added to the dictionary
                if (itemQuantities.ContainsKey(item.name))
                {
                    //Increment the quantity of the item if a duplicate is found
                    itemQuantities[item.name]++;
                }
                else
                {
                    //Add item to the dictionary if it's the first occurrence
                    itemQuantities[item.name] = 1;
                }
                
                double salesTax = item.CalculateSalesTax(); //calculates sales tax for item
                double importTax = Math.Ceiling(item.price * 0.05 *20)/20;  //calculates import tax for item
                double itemTotal = item.price + Math.Ceiling(item.tax *20)/20;  //calculates individual item price + tax 

                //Used to calculate total sales tax based on if item are imported or not
                if(item.isImported)
                {
                    receipt.totalSalesTax += Math.Ceiling(salesTax * 20)/20 + importTax;
                }
                else
                {
                    receipt.totalSalesTax += salesTax;
                }

                receipt.total += itemTotal;
            }

            return receipt;
        }
    }
}
