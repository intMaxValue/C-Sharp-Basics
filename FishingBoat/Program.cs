using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermansCount = int.Parse(Console.ReadLine());


            if (season == "Spring")
            {
                double rent = 3000;
                if (fishermansCount <= 6)
                {
                    rent *= 0.9;
                }
                else if (fishermansCount > 7 && fishermansCount <= 11)
                {
                    rent *= 0.85;
                }
                else if (fishermansCount > 12)
                {
                    rent *= 0.75;
                }

                if (fishermansCount % 2 == 0 && budget >= rent)
                {
                    double discount = budget - (rent * 0.95);
                    Console.WriteLine($"Yes! You have {discount:F2} leva left.");
                }
                else if (fishermansCount % 2 == 0 && budget < rent)
                {
                    double moneyNeeded = (rent * 0.95) - budget;
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
                else if (fishermansCount % 2 != 0 && budget >= rent)
                {
                    double moneyLeft = budget - rent;
                    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
                }
                else if (fishermansCount % 2 != 0 && budget < rent)
                {
                    double moneyNeeded = (rent - budget);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }

                

            }
            else if (season == "Summer" || season == "Autumn")
            {
                double rent = 4200;
                if (fishermansCount <= 6)
                {
                    rent *= 0.9;
                }
                else if (fishermansCount > 7 && fishermansCount <= 11)
                {
                    rent *= 0.85;
                }
                else if (fishermansCount > 12)
                {
                    rent *= 0.75;
                }

                if (fishermansCount % 2 == 0 && budget >= rent && season == "Summer")
                {
                    double discount = budget - (rent * 0.95);
                    Console.WriteLine($"Yes! You have {discount:F2} leva left.");
                }
                else if (fishermansCount % 2 == 0 && budget < rent && season == "Summer")
                {
                    double moneyNeeded = (rent - budget);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
                else if (fishermansCount % 2 != 0 && budget >= rent)
                {
                    double moneyLeft = budget - rent;
                    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
                }
                else if (fishermansCount % 2 != 0 && budget < rent)
                {
                    double moneyNeeded = (rent - budget);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
                else if (fishermansCount % 2 == 0 && budget < rent)
                {
                    double moneyNeeded = (rent - budget);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }


            }
            else if (season == "Winter")
            {
                double rent = 2600;
                if (fishermansCount <= 6)
                {
                    rent *= 0.9;
                }
                else if (fishermansCount > 7 && fishermansCount <= 11)
                {
                    rent *= 0.85;
                }
                else if (fishermansCount > 12)
                {
                    rent *= 0.75;
                }

                if (fishermansCount % 2 == 0 && budget >= rent)
                {
                    double discount = budget - (rent * 0.95);
                    Console.WriteLine($"Yes! You have {discount:F2} leva left.");
                }
                else if (fishermansCount % 2 == 0 && budget < rent)
                {
                    double moneyNeeded = (rent - budget);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
                else if (fishermansCount % 2 != 0 && budget >= rent)
                {
                    double moneyLeft = budget - rent;
                    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
                }
                else if (fishermansCount % 2 != 0 && budget < rent)
                {
                    double moneyNeeded = (rent - budget);
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
            }



        }
    }
}
