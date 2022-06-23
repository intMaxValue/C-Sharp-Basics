using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double degrees = radians * 180 / pi;
            Console.WriteLine(degrees);
        }
    }
}
