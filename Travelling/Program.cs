using System;

namespace Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }

                double expenses = double.Parse(Console.ReadLine()),
                savings = 0;

                while (savings < expenses)
                {
                    double money = double.Parse(Console.ReadLine());
                    savings += money;
                }

                Console.WriteLine($"Going to {destination}!");

            }
        }
    }
}
