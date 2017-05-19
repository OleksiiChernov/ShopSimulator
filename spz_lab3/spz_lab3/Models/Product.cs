using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spz_lab3.Models
{
    public class Product
    {
        public static Product GenerateNewProduct()
        {
            Random r = new Random();
            float tradePrice = r.Next(Constants.Products.MinTradePrice, Constants.Products.MaxTradePrice);
            float retailPrice = tradePrice * (float)(1.0f + r.NextDouble());
            return new Product(Constants.Products.GetRandomProductName(), tradePrice, retailPrice);
        }

        /// <summary>
        /// Create new instance of <see cref="Product"/>
        /// </summary>
        /// <param name="name">Product name</param>
        /// <param name="tradePrice">Product trade price</param>
        /// <param name="retailPrice">Product retail price</param>
        public Product(string name, float tradePrice, float retailPrice)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }
            Name = name;
            TradePrice = tradePrice;
            RetailPrice = retailPrice;
        }

        /// <summary>
        /// Create new instance of <see cref="Product"/>
        /// </summary>
        public Product()
        {
            
        }

        public string Name { get; private set; }
        public float TradePrice { get; private set; }
        public float RetailPrice { get; private set; }
    }
}
