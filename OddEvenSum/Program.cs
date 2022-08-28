using System;

namespace OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < numberCount; i++)
            {
                if (i % 2 == 0)
                {
                    int oddNum = int.Parse(Console.ReadLine());
                    sumOdd += oddNum;
                }
                else
                {
                    int evenNum = int.Parse(Console.ReadLine());
                    sumEven += evenNum;
                }
                
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sumOdd);
            }
            else
            {
                int difference = Math.Abs(sumEven - sumOdd);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(difference));
            }
        }
    }
}
