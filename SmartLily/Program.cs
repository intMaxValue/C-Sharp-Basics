using System;

namespace SmartLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int totalToysPrice = 0;
            int totalMoneyGift = 0;
            int previousMoneyBonus = 0;
            int brothaTakes = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoneyGift += 10 + previousMoneyBonus - brothaTakes;
                    previousMoneyBonus += 10;

                }

                else
                {
                    totalToysPrice += toyPrice;
                }
            }

            double grandTotal = totalMoneyGift + totalToysPrice;

            if (grandTotal >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {grandTotal - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - grandTotal:F2}");
            }
        }
    }
}
