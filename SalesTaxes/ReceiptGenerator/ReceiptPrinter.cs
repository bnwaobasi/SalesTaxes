using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTaxes.ShoppingItemTypes;

namespace SalesTaxes.ReceiptGenerator
{
    class ReceiptPrinter
    {
        //Method used to print final receipt output
        public void PrintReceipt(Receipt receipt)
        {
            //Used to keep track of Item quantities
            var itemQuantities = new Dictionary<string, int>(); 

            foreach (var item in receipt.items)
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
            }

            //Used to keep track of items that have been printed in receipt
            var printedItems = new List<string>();

            foreach (var item in receipt.items)
            {
                if (!printedItems.Contains(item.name))
                {
                    int quantity = itemQuantities[item.name]; //Get the quantity of the item

                    //Format used to list item based on quantity
                    if (quantity > 1)
                    {
                        Console.WriteLine($"{item.name}: {(item.price + item.tax) * quantity:F2} ({quantity} @ {item.price:F2})");
                    }
                    else
                    {
                        Console.WriteLine($"{item.name}: {item.price + item.tax:F2}");
                    }

                    printedItems.Add(item.name); //Add the item to the printed items list
                }
            }

            Console.WriteLine($"Sales Taxes: {receipt.totalSalesTax:F2}");
            Console.WriteLine($"Total: {receipt.total:F2}");
        }

    }
}
