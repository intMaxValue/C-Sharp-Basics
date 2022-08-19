using System;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();

            if (@operator == "+")
            {
                double result = n1 + n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }

            }

            else if (@operator == "-")
            {
                double result = n1 - n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }

            }

            else if (@operator == "*")
            {
                double result = n1 * n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }

            }

            else if (@operator == "/")
            {
                double result = n1 / n2;

                if (n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n2} by zero");
                }
                else if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {result:F2}");
                }
                

            }

            else if (@operator == "%")
            {
                double result = n1 % n2;

                if (n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n2} by zero");
                }
                else if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }

            }
        }

    }
}
