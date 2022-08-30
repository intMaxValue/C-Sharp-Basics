using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabsOpen = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            string website = "";

            for (int i = 0; i < tabsOpen; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

                website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
                
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}
