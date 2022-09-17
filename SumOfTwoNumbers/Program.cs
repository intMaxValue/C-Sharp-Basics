using System;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    sum = i + j;
                    combinations++;

                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");



        }
    }
}





