using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spz_lab3.Models;

namespace spz_lab3.Controllers
{
    public class ProductStorage
    {
        private List<Product> _availableProducts;

        public ProductStorage()
        {
            _availableProducts = new List<Product>();
        }

        public Product GetRandomProduct()
        {
            Product result = null;
            result = _availableProducts?.PickRandom();
            _availableProducts?.Remove(result);
            return result;
        }

        public Product GetProduct(string productName)
        {
            Product result = null;
            if (!string.IsNullOrWhiteSpace(productName))
            {
                result = _availableProducts?.FirstOrDefault(prod => prod.Name.Equals(productName));
                if (null != result)
                {
                    _availableProducts?.Remove(result);
                }
            }
            return result;
        }

        public void AddProduct(Product product)
        {
            if (null == product)
            {
                return;
            }
            if (null == _availableProducts)
            {
                _availableProducts = new List<Product>();
            }
            _availableProducts.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            if (null == _availableProducts)
            {
                _availableProducts = new List<Product>();
            }
            return _availableProducts;
        }

        public void FillStorage()
        {
            if (null == _availableProducts)
            {
                _availableProducts = new List<Product>();
            }
            List<string> productNames = Constants.Products.ProductNames;

            Random r = new Random();
            foreach (var product in productNames)
            {
                int count = r.Next(Constants.Products.MinProductCount, Constants.Products.MaxProductCount);
                _availableProducts.AddRange(Enumerable.Repeat(Product.GenerateNewProduct(product), count));
            }

        }


        public EventHandler<NewLogEventArgs> OnNewLog { get; set; }

    }
}
