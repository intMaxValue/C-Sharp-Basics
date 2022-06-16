using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = (lenght * width * height) * 0.001;
            double accessories = percent / 100;
            double volumeWithAccessories = volume * (1 - accessories);

            Console.WriteLine(volumeWithAccessories);
        }
    }
}
