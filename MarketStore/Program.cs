using MarketStore.models;
using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            BronzeCard bronzeCardOwner = new BronzeCard(1, 0);
            SilverCard silverCardOwner = new SilverCard(1, 600);
            GoldCard goldCardOwner = new GoldCard(3, 1500);
            Console.WriteLine("Bronze:");
            bronzeCardOwner.CurrentPurchase(150);
            Console.WriteLine("Silver:");
            silverCardOwner.CurrentPurchase(850);
            Console.WriteLine("Gold:");
            goldCardOwner.CurrentPurchase(1300);
        }
    }
}
