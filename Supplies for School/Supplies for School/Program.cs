using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double penPrice = 5.80;
            double markerPrice = 7.20;
            double detergent = 1.20;

            int penQuantity = int.Parse(Console.ReadLine());
            int markerQuantity = int.Parse(Console.ReadLine());
            int detergentQuantity = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double totalPenPrice = penQuantity * penPrice;
            double totalMarkerPrice = markerQuantity * markerPrice;
            double totalDetergentPrice = detergentQuantity * detergent;

            double totalPrice = totalPenPrice + totalMarkerPrice + totalDetergentPrice;

            double totalDiscount = totalPrice * (percentDiscount * 0.01);

            Console.WriteLine(totalPrice - totalDiscount);
        }
    }
}
