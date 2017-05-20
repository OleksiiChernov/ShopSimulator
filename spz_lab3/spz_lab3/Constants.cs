using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spz_lab3
{
    public class Constants
    {
        public class Products
        {
            public const int MinTradePrice = 1;
            public const int MaxTradePrice = 200;
            public const int MinProductCount = 1;
            public const int MaxProductCount = 100;
            public static readonly List<string> ProductNames = new List<string>
            {
                "Pen", "Table", "Powerbank", "Iphone", "Laptop", "Lamp", "Mirror", "Toy",
                "Vase", "Chair", "TV", "Playstation", "Headset", "Air conditioner", "Coffee",
                "Tea", "Milk", "Apple", "Water", "Cake", "Sugar", "Meat", "Bag", "Camera", "Book"
            };
            public static string GetRandomProductName()
            {
                string result = null;
                result = ProductNames.PickRandom();
                return result;
            }
        }

        public class PeoplesNames
        {
            public static readonly List<string> Names = new List<string>
            {
                "Mike", "Todd", "Phill", "Tandy", "Alex", "Max", "Fione", "Melissa", "Carol",
                "Phibi", "Andrey", "Michael", "Marshall", "Lilly", "Barny", "Peter", "Angela",
                "Rebecca", "Erica", "Betty", "Robert", "Kira", "John", "Adam", "Emma", "Gary"
            };
            public static string GetRandomName()
            {
                string result = null;
                result = Names.PickRandom();
                return result;
            }
        }

        public const int MinThreadSleep = 5000;
        public const int MaxThreadSleep = 60000;
        public const int TimerBaseTime = 150000;
        public const int BaseCash = 10000;
    }
}
