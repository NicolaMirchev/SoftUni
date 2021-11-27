using System;
using System.Collections.Generic;
using System.Text;

namespace INStock
{
    public abstract class Product
    {
        public Product(string label, int price, int quantity)
        {
            Label = label;
            Price = price;
            Quantity = quantity;
        }

        public string Label { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; set; }

    }
}
