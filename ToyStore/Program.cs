using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {        
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzleQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int teddyBearQuantity = int.Parse(Console.ReadLine());
            int minionQuantity = int.Parse(Console.ReadLine());
            int truckQuantity = int.Parse(Console.ReadLine());

            double totalPrice = puzzleQuantity * 2.60 + dollsQuantity * 3 + teddyBearQuantity * 4.10 + minionQuantity * 8.20 + truckQuantity * 2;
            int totalQuantity = puzzleQuantity + dollsQuantity + teddyBearQuantity + minionQuantity + truckQuantity;

            if (totalQuantity >= 50)
            {
                totalPrice *= 0.75;
            }

            double totalPriceWithRent = totalPrice * 0.9;

            if (totalPriceWithRent >= tripPrice)
            {
                Console.WriteLine($"Yes! {totalPriceWithRent - tripPrice:F2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPriceWithRent:F2} lv needed.");
            }
        }
    }
}
