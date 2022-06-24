using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegieMenu = 8.15;
            double delivery = 2.50;

            int chickenMenuQuantity = int.Parse(Console.ReadLine());
            int fishMenuQuantity = int.Parse(Console.ReadLine());
            int vegieMenuQuantity = int.Parse(Console.ReadLine());

            double totalPrice = (chickenMenu * chickenMenuQuantity) + (fishMenu * fishMenuQuantity) + (vegieMenu * vegieMenuQuantity);
            double dessertPrice = totalPrice * 0.2;
            double totalPriceWithDessertAndDelivery = totalPrice + dessertPrice + delivery;

            Console.WriteLine(totalPriceWithDessertAndDelivery);
        }
    }
}
