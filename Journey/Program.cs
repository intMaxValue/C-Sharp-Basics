using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double expenses = 0;
            string campOrHotel = "";

            if (budget <= 100.00)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    campOrHotel = "Camp";
                    expenses = budget * 0.3;
                }
                if (season == "winter")
                {
                    campOrHotel = "Hotel";
                    expenses = budget * 0.7;
                }
            }

            else if (budget >100 && budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    campOrHotel = "Camp";
                    expenses = budget * 0.4;
                }
                if (season == "winter")
                {
                    campOrHotel = "Hotel";
                    expenses = budget * 0.8;
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    campOrHotel = "Hotel";
                    expenses = budget * 0.9;
                }
                if (season == "winter")
                {
                    campOrHotel = "Hotel";
                    expenses = budget * 0.9;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {expenses:F2}");

        }
    }
}
