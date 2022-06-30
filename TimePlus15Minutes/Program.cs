using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalTimeInMinutesPlus15 = hour * 60 + minutes +15;

            int newHours = totalTimeInMinutesPlus15 / 60;
            int newMinutes = totalTimeInMinutesPlus15 % 60;

            if (newHours == 24)
            {
                newHours = 00;
            }

            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
           
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
