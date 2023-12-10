using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOnliner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
            stockExchangeMonitor.PriceChangeHandler = ShowPrice;
            stockExchangeMonitor.Start();
            


        }
        public static void ShowPrice(int price)
        {
            Console.WriteLine($"Новая цена сейчас: {price}");
            Console.ReadKey();
        }

    }
}

