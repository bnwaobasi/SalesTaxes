using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes.ShoppingItemTypes
{
    class ImportedItem
    {
        private Item item;

        //constructor
        public ImportedItem(Item item) 
        {
            this.item = item;
        }

        public double getImportTax()
        {
            item.isImported = true;
            double importTax = Math.Ceiling(item.price * 0.05 * 20)/20;
            return importTax;
        }

        //public double addImportTax()
        //{
        //    item.isImported = true;
        //    double importedItemPrice = item.price + Math.Ceiling(item.price * .05 * 20)/20; //used to round up tax to nearest 0.05
        //    return importedItemPrice;
        //}
    }
}
