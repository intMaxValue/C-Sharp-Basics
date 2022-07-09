using System;

namespace WorkingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (dayOfTheWeek == "Monday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfTheWeek == "Tuesday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfTheWeek == "Wednesday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfTheWeek == "Thursday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfTheWeek == "Friday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }

            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
