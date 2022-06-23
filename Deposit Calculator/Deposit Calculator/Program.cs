using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double interestPerMonth = deposit * ((interest * 0.01) / 12);

            double total = deposit + (months * interestPerMonth);
            
            Console.WriteLine(total);
        }
    }
}
