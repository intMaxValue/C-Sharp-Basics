using System;

namespace SwimingWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsFor1Meter = double.Parse(Console.ReadLine());

            double totalTimeSwiming = distanceInMeters * timeInSecondsFor1Meter;
            double resistance = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTimeWithWaterResistance = totalTimeSwiming + resistance;

            if (totalTimeWithWaterResistance >= recordInSeconds)
            {
                Console.WriteLine($"No, he failed! He was {totalTimeWithWaterResistance - recordInSeconds:F2} seconds slower.");
            }

            else if (totalTimeWithWaterResistance < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeWithWaterResistance:F2} seconds.");
            }
        }
    }
}
