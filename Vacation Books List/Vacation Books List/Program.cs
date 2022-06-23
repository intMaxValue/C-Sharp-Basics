using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesPerBook = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalTimePerBook = pagesPerBook / pagesReadPerHour;
            int hoursPerDay = totalTimePerBook / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
