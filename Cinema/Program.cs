using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rowCount = int.Parse(Console.ReadLine());
            int columnCount = int.Parse(Console.ReadLine());

            int totalSeats = rowCount * columnCount;

            if (typeProjection == "Premiere")
            {
                double income = totalSeats * 12.00;
                Console.WriteLine($"{income:F2} leva");
            }

            else if (typeProjection == "Normal")
            {
                double income = totalSeats * 7.50;
                Console.WriteLine($"{income:F2} leva");
            }

            else if (typeProjection == "Discount")
            {
                double income = totalSeats * 5.00;
                Console.WriteLine($"{income:F2} leva");
            }
        }
    }
}
