using System;

namespace TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            if (volume >= 0 && volume <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", volume * 0.05);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", volume * 0.045);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", volume * 0.055);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            if (volume > 500 && volume <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", volume * 0.07);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", volume * 0.075);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", volume * 0.08);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            if (volume > 1000 && volume <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", volume * 0.08);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", volume * 0.10);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", volume * 0.12);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            if (volume > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", volume * 0.12);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", volume * 0.13);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", volume * 0.145);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            if (volume < 0)
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
