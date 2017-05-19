using System;
using System.Collections.Generic;

namespace spz_lab3.Models
{
    public class Customer
    {
        public Customer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }
            Name = name;
            Items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            if (null == product)
            {
                return;
            }
            if (null == Items)
            {
                Items = new List<Product>();
            }
            Items.Add(product);
        }

        public string Name { get; private set; }
        public List<Product> Items { get; private set; }
    }
}
