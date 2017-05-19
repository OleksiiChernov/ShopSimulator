using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using spz_lab3.Models;

namespace spz_lab3.Controllers
{
    public enum ShopMode
    {
        Normal,
        Inventory
    }

    public class ShopController
    {
        private static ShopController _instance;
        private ShopMode _mode;
        private ProductStorage _shopController;
        private float _cash;
        private List<Customer> _customers;

        private void NormalModeSimulation()
        {
            Random r = new Random();
            while (true)
            {
                Customer customer = new Customer(Constants.PeoplesNames.GetRandomName());
                int sleep = r.Next(Constants.MinThreadSleep, Constants.MaxThreadSleep);
                Thread.Sleep(sleep);
                customer.AddItem(BuyRandomProduct());
                if (null == _customers)
                {
                    _customers = new List<Customer>();
                }
                _customers.Add(customer);
            }
        }

        private void InventoryModeSimulation()
        {
            while (_cash > 0)
            {
                FillStorageByOneProduct();
            }
        }

        private Product BuyRandomProduct()
        {
            if (null == _shopController)
            {
                _shopController = new ProductStorage();
            }
            Product product = _shopController.GetRandomProduct();
            if (null != product)
            {
                _cash += product.RetailPrice;
            }
            return product;
        }

        private void FillStorageByOneProduct()
        {
            Product product = Product.GenerateNewProduct();

            if (product.TradePrice > _cash)
            {
                return;
            }
            if (null == _shopController)
            {
                _shopController = new ProductStorage();
            }
            _shopController.AddProduct(product);
            _cash -= product.TradePrice;
        }

        public ShopController Instance => _instance ?? (_instance = new ShopController());
    }
}
