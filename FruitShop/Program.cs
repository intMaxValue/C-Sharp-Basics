using System;

namespace FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                    if (fruit == "banana")
                    {
                        Console.WriteLine("{0:F2}", 2.50 * quantity);
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine("{0:F2}", 1.20 * quantity);
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine("{0:F2}", 0.85 * quantity);
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine("{0:F2}", 1.45 * quantity);
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine("{0:F2}", 2.70 * quantity);
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine("{0:F2}", 5.50 * quantity);
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine("{0:F2}", 3.85 * quantity);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

            

                case "Saturday":
                case "Sunday":

                    if (fruit == "banana")
                    {
                        Console.WriteLine("{0:F2}", 2.70 * quantity);
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine("{0:F2}", 1.25 * quantity);
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine("{0:F2}", 0.90 * quantity);
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine("{0:F2}", 1.60 * quantity);
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine("{0:F2}", 3.00 * quantity);
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine("{0:F2}", 5.60 * quantity);
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine("{0:F2}", 4.20 * quantity);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
