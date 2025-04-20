using System;
using System.Collections.Generic;

namespace CSharpDay3
{
    public class Product
    {
        public Product(string name, Color col, Size sz, string bnd)
        {
            Name = name;
            Color = col;
            Size = sz;
            Brand = bnd;
        }

        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public string Brand { get; set; }

        public string ToString()
        {
            return $"{Name}, {Color}, {Size}, {Brand}";
        }
    }
}