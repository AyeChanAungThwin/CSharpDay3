using System;
using System.Collections.Generic;

namespace CSharpDay3
{
    public class ProductFilter: Filter<Product>
    {
        public void filter(List<Product> data, Predicate<Product> item)
        {
            foreach (var product in data)
            {
                if (item.isMatched(product))
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
}