using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyPrice = int.Parse(Console.ReadLine());

            double sneakers = yearlyPrice - (yearlyPrice * 0.4);
            double uniform = sneakers - (sneakers * 0.2);
            double ball = uniform / 4;
            double accessories = ball / 5;

            double totalPrice = yearlyPrice + sneakers + uniform + ball + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}
