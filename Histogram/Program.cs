using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            double lessThan200 = 0;
            double between200And399 = 0;
            double between400And599 = 0;
            double between600And799 = 0;
            double moreThan800 = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 200)
                {
                    lessThan200++;
                }
                else if (input >= 200 && input <= 399)
                {
                    between200And399++;
                }
                else if (input >= 400 && input <= 599)
                {
                    between400And599++;
                }
                else if (input >= 600 && input <= 799)
                {
                    between600And799++;
                }
                else if (input >= 800)
                {
                    moreThan800++;
                }
            }
            double first = lessThan200 / numberCount * 100;
            Console.WriteLine($"{first:F2}%");

            double second = between200And399 / numberCount * 100;
            Console.WriteLine($"{second:F2}%");

            double third = between400And599 / numberCount * 100;
            Console.WriteLine($"{third:F2}%");

            double fourth = between600And799 / numberCount * 100;
            Console.WriteLine($"{fourth:F2}%");

            double fifth = moreThan800 / numberCount * 100;
            Console.WriteLine($"{fifth:F2}%");
        }
    }
}
