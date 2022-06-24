using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonPrice = 1.50;
            double paint = 14.50;
            double paintThinner = 5.00;
            double bags = 0.40;

            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int paintThinnerQuantity = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            double totalNylonPrice = nylonPrice * (nylonQuantity + 2);
            double totalPaintPrice = paint * (paintQuantity + (paintQuantity * 0.1));
            double totalPaintThinnerPrice = paintThinner * paintThinnerQuantity;

            double totalMaterialsPrice = totalNylonPrice + totalPaintPrice + totalPaintThinnerPrice + bags;
            double paintersPrice = (totalMaterialsPrice * 0.3) * hoursWork;
            double totalPrice = totalMaterialsPrice + paintersPrice;

            Console.WriteLine(totalPrice);


        }
    }
}
