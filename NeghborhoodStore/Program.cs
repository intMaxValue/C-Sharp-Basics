using System;

namespace NeghborhoodStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.2);         // WHY? 3 * 1.2 = 3.5999999999999996?
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.6);
                }
            }

            if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.3);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.5);
                }
            }
            if (city == "Varna")
            {
                 if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.1);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}
