using System;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int difference = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
