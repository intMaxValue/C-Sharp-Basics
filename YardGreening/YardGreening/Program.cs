using System;

namespace TESTLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerSquareMeter = 7.61;
            double discountPerSquareMeter = 0.18;
            double squareMeters = double.Parse(Console.ReadLine());
            double totalPrice = squareMeters * pricePerSquareMeter;
            double totalDiscount = discountPerSquareMeter * totalPrice;
            double totalPriceWithDiscount = totalPrice - totalDiscount;

            Console.WriteLine("The final price is: " + totalPriceWithDiscount + " lv.");
            Console.WriteLine("The discount is: " + totalDiscount + " lv.");


        }
    }
}
