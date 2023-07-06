using System;
using System.Collections.Generic;
using SalesTaxes.ShoppingItemTypes;

namespace SalesTaxes
{
    class Program
    {
        public static void Main(string[] args) 
        {
            CheckOut sale = new CheckOut();
            sale.RunSales();
        }
    }
}
