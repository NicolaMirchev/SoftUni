using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INStock
{
    public class Stock
    {
        public Stock()
        {
            stocks = new List<Product>();
        }
        public int Count { get => stocks.Count; }

        private List<Product> stocks;

        public void Add(Product product)
        {
            if (stocks.Any( p => p.Label == product.Label))
            {
                throw new Exception("Label must me uniqe!");
            }
            else 
            {
                stocks.Add(product);
            }
        }
            
        public bool Contains(Product product)
        {
            Type type = product.GetType();

            for (int i = 0; i < stocks.Count; i++)
            {
                Type typeOfTheProduct = stocks[i].GetType();

                if (type.Name == typeOfTheProduct.Name)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
