using System;

namespace HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                if (input > maxValue)
                {
                    maxValue = input;
                }


            }
            int sumWithoutMaxValue = sum - maxValue;
            int diff = Math.Abs(maxValue - sumWithoutMaxValue);

            if (maxValue == sumWithoutMaxValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxValue}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
