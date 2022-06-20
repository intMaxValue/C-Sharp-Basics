using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cm = 2.54;
            double area = inches * cm;
            Console.WriteLine(area);
        }
    }
}
