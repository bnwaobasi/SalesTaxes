using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTaxes.ReceiptGenerator;
using SalesTaxes.ShoppingItemTypes;

namespace SalesTaxes
{
    class CheckOut
    {
        //Controls user imput queries to add items to shopping basket
        public void RunSales()
        {
            List<Item> shoppingBasket = new List<Item>();
            bool addItem = true;

            while (addItem)
            {
                Console.WriteLine("Enter item name: ");
                string name = Console.ReadLine().ToLower();
                name = char.ToUpper(name[0]) + name.Substring(1);

                Console.WriteLine("Enter item price: ");
                double price;
                while (!double.TryParse(Console.ReadLine(), out price)) //checks if parsing succeeded, updates parsed price
                {
                    Console.WriteLine("Invalid price. Please enter a valid number: ");
                }


                Console.WriteLine("Is the item imported(Y/N): ");
                bool isImport = Console.ReadLine().ToUpper() == "Y";
                Item item;
                if (isImport)
                {
                    Console.WriteLine("Is the item exempt from sales tax? (Y/N): ");
                    bool isExempt = Console.ReadLine().ToUpper() == "Y";

                    if (isExempt)
                    {
                   
                        item = new ExemptItem(name, price);
                        ImportedItem importedItem = new ImportedItem(item);
                        item.tax = importedItem.getImportTax();
                    }
                    else
                    {
                        item = new StandardItem(name, price);
                        ImportedItem importedItem = new ImportedItem(item);
                        item.tax = importedItem.getImportTax() + item.CalculateSalesTax();
                    }
                }
                else
                {
                    Console.WriteLine("Is the item exempt from sales tax? (Y/N): ");
                    bool isExempt = Console.ReadLine().ToUpper() == "Y";

                    if (isExempt)
                    {
                        item = new ExemptItem(name, price);
                    }
                    else
                    {
                        item = new StandardItem(name, price);
                    }
                }

                shoppingBasket.Add(item);

                Console.WriteLine("Item added to the shopping basket.");

                Console.WriteLine("Do you want to add another item? (Y/N): ");
                addItem = Console.ReadLine().ToUpper() == "Y";
            }

            ReceiptWriter receiptWriter = new ReceiptWriter();
            Receipt receipt = receiptWriter.CreateReceipt(shoppingBasket);

            ReceiptPrinter receiptPrinter = new ReceiptPrinter();
            receiptPrinter.PrintReceipt(receipt);
        }
    }
}
