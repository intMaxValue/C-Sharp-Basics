using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuPrice = 250;
            double cpuPrice = 0.35 * (gpuCount * gpuPrice);
            double ramPrice = 0.1 * (gpuCount * gpuPrice);

            double totalPrice = gpuCount * gpuPrice + cpuCount * cpuPrice + ramCount * ramPrice;

            if (gpuCount > cpuCount)
            {
                totalPrice = totalPrice * 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
            }

            else if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
            }
        }
    }
}
