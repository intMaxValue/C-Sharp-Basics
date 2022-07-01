using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double pricePerCostume = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double totalCostumesMoney = extrasCount * pricePerCostume;

            if (extrasCount > 150)
            {
                totalCostumesMoney *= 0.9;
            }

            double totalPrice = totalCostumesMoney + decor;

            if (budget < totalPrice)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:F2} leva more.");
            }

            else if (budget >= totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:F2} leva left.");
            }
        }
    }
}
