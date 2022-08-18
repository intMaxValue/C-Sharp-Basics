using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                double studioPrice = 50;
                double appartmentPrice = 65;

                if (nights > 7 && nights <= 14)
                {
                    studioPrice *= 0.95;
                }

                else if (nights > 14)
                {
                    studioPrice *= 0.70;
                    appartmentPrice *= 0.90;
                }

                double totalPriceStudio = nights * studioPrice;
                double totalPriceAppartment = nights * appartmentPrice;

                Console.WriteLine($"Apartment: {totalPriceAppartment:F2} lv.");
                Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");

            }

            else if (month == "June" || month == "September")
            {
                double studioPrice = 75.20;
                double appartmentPrice = 68.70;
                
                if (nights > 14)
                {
                    studioPrice *= 0.80;
                    appartmentPrice *= 0.90;
                }

                double totalPriceStudio = nights * studioPrice;
                double totalPriceAppartment = nights * appartmentPrice;

                Console.WriteLine($"Apartment: {totalPriceAppartment:F2} lv.");
                Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
            }

            else if (month == "July" || month == "August")
            {
                double studioPrice = 76;
                double appartmentPrice = 77;

                if (nights > 14)
                {
                    appartmentPrice *= 0.90;
                }

                double totalPriceStudio = nights * studioPrice;
                double totalPriceAppartment = nights * appartmentPrice;

                Console.WriteLine($"Apartment: {totalPriceAppartment:F2} lv.");
                Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
            }
        }
    }
}
