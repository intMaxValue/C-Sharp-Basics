using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (typeFlowers == "Roses")
            {
                if (countFlowers > 80)
                {
                    totalPrice = (countFlowers * 5) * 0.9;
                }
                else
                {
                    totalPrice = countFlowers * 5;
                }
            }

            if (typeFlowers == "Dahlias")
            {
                if (countFlowers > 90)
                {
                    totalPrice = (countFlowers * 3.80) * 0.85;
                }
                else
                {
                    totalPrice = countFlowers * 3.80;
                }
            }

            if (typeFlowers == "Tulips")
            {
                if (countFlowers > 80)
                {
                    totalPrice = (countFlowers * 2.80) * 0.85;
                }
                else
                {
                    totalPrice = countFlowers * 2.80;
                }
            }

            if (typeFlowers == "Narcissus")
            {
                if (countFlowers < 120)
                {
                    totalPrice = (countFlowers * 3.00) * 1.15;
                }
                else
                {
                    totalPrice = countFlowers * 3.00;
                }
            }

            if (typeFlowers == "Gladiolus")
            {
                if (countFlowers < 80)
                {
                    totalPrice = (countFlowers * 2.50) * 1.20;
                }
                else
                {
                    totalPrice = countFlowers * 2.50;
                }
            }

            if (totalPrice <= budget)
            {
                double moneyLeft = budget - totalPrice;

                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {moneyLeft:F2} leva left.");
            }

            else if (totalPrice > budget)
            {
                double moneyNeeded = totalPrice - budget;

                Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
            }
        }
    }
}
