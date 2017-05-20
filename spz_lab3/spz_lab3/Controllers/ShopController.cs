using spz_lab3.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace spz_lab3.Controllers
{
    public enum ShopMode
    {
        Normal,
        Inventory
    }

    public class ShopController
    {

        #region Variables

        private static ShopController _instance;
        private ShopMode _mode;
        private ProductStorage _storageController;
        private float _cash;
        private List<Customer> _customers;
        private Task _normalModeSimulator;
        private Task _inventoryModeSimulator;
        private System.Timers.Timer _selector;

        #endregion


        #region Interface

        public ShopController()
        {
            _mode = ShopMode.Normal;
            _storageController = new ProductStorage();
            _cash = Constants.BaseCash;
            _customers = new List<Customer>();
            _normalModeSimulator = new Task(NormalModeSimulation);
            _inventoryModeSimulator = new Task(InventoryModeSimulation);
            InitTimer();
        }

        public void SetMode(ShopMode mode)
        {
            StartTask(mode);
        }

        #endregion


        #region Implementation

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
            if (null == _storageController)
            {
                _storageController = new ProductStorage();
            }
            Product product = _storageController.GetRandomProduct();
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
            if (null == _storageController)
            {
                _storageController = new ProductStorage();
            }
            _storageController.AddProduct(product);
            _cash -= product.TradePrice;
        }

        private void InitTask(ShopMode mode)
        {
            switch (mode)
            {
                case ShopMode.Normal:
                    _normalModeSimulator = new Task(NormalModeSimulation);
                    break;
                case ShopMode.Inventory:
                    _inventoryModeSimulator = new Task(InventoryModeSimulation);
                    break;
            }
        }

        private void StartTask(ShopMode mode)
        {
            Task taskToStart = mode == ShopMode.Normal ? _normalModeSimulator : _inventoryModeSimulator;
            Task taskToDispose = mode == ShopMode.Normal ? _inventoryModeSimulator : _normalModeSimulator;

            if (taskToDispose.Status == TaskStatus.Running)
            {
                taskToDispose.Dispose();
            }
            InitTask(mode);
            taskToStart.Start();
            InitTimer();
        }

        private void InitTimer()
        {
            if (null != _selector)
            {
                _selector.Elapsed -= SelectorOnElapsed;
            }
            _selector = new System.Timers.Timer(Constants.TimerBaseTime);
            _selector.AutoReset = true;
            _selector.Start();
            _selector.Elapsed += SelectorOnElapsed; 
        }

        private void SelectorOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (_mode == ShopMode.Inventory)
            {
                _mode = ShopMode.Normal;
            }
            if (_mode == ShopMode.Normal)
            {
                _mode = ShopMode.Inventory;
            }
            SetMode(_mode);
        }

        #endregion

        public ShopController Instance => _instance ?? (_instance = new ShopController());
    }
}
