using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Delegate
    {
        public delegate void NoParameters();

        public delegate string WithParameters(string name, string surname);
        public static int result;
        public  static void ShowMessage()
        {
            Console.Write("\nHello Baku");
        }

        public static string ShowMessage2(string name, string surname)
        {
            return  $"Fullname: {name} {surname}";
        }

        public static void ShowMultiCasting()
        {
            Console.Write(" and Azerbaijan\n");
        }

        public static int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }
        public static bool IsApple(string modelName)
        {
            if (modelName == "I Phone X")
                return true;
            else
                return false;
        }
    }

    class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int price = new Random().Next(1000);

                PriceChangeHandler(price);

                Thread.Sleep(2000);
            }
        }
    }

    class PriceChange
    {
        public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
        public class Broadcaster
        {
            // Event declaration
            public event PriceChangedHandler PriceChanged;
        }

    }

}
