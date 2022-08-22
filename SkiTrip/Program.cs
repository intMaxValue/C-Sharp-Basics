using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string review = Console.ReadLine();

            int nights = days - 1;
            double totalPrice = 0;

            if (typeOfRoom == "room for one person")
            {
                totalPrice = nights * 18.00;
                if (review == "positive")
                {
                    totalPrice *= 1.25;
                }
                else if (review == "negative")
                {
                    totalPrice *= 0.9;
                }
                Console.WriteLine($"{totalPrice:F2}");
            }

            else if (typeOfRoom == "apartment")
            {
                if (days < 10)
                {
                    totalPrice = (nights * 25.00) * 0.7;
                    if (review == "positive")
                    {
                        totalPrice *= 1.25;
                    }
                    else if (review == "negative")
                    {
                        totalPrice *= 0.9;
                    }
                }
                else if (days > 10 && days <= 15)
                {
                    totalPrice = (nights * 25.00) * 0.65;
                    if (review == "positive")
                    {
                        totalPrice *= 1.25;
                    }
                    else if (review == "negative")
                    {
                        totalPrice *= 0.9;
                    }
                }
                else if (days > 15)
                {
                    totalPrice = (nights * 25.00) * 0.5;
                    if (review == "positive")
                    {
                        totalPrice *= 1.25;
                    }
                    else if (review == "negative")
                    {
                        totalPrice *= 0.9;
                    }
                }
                Console.WriteLine($"{totalPrice:F2}");


            }

            else if (typeOfRoom == "president apartment")
            {
                if (days < 10)
                {
                    totalPrice = (nights * 35.00) * 0.9;
                    if (review == "positive")
                    {
                        totalPrice *= 1.25;
                    }
                    else if (review == "negative")
                    {
                        totalPrice *= 0.9;
                    }
                }
                else if (days > 10 && days <= 15)
                {
                    totalPrice = (nights * 35.00) * 0.85;
                    if (review == "positive")
                    {
                        totalPrice *= 1.25;
                    }
                    else if (review == "negative")
                    {
                        totalPrice *= 0.9;
                    }
                }
                else if (days > 15)
                {
                    totalPrice = (nights * 35.00) * 0.8;
                    if (review == "positive")
                    {
                        totalPrice *= 1.25;
                    }
                    else if (review == "negative")
                    {
                        totalPrice *= 0.9;
                    }
                }
                Console.WriteLine($"{totalPrice:F2}");

            }
        }
    }
}
