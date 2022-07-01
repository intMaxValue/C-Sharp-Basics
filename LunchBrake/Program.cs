using System;

namespace LunchBrake
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShowName = Console.ReadLine();
            int timePerEpisode = int.Parse(Console.ReadLine());
            int totalBreakTime = int.Parse(Console.ReadLine());

            double lunchTime = totalBreakTime / 8.0;
            double chillTime = totalBreakTime / 4.0;

            double breakTimeLeftForTv = totalBreakTime - lunchTime - chillTime;

            if (breakTimeLeftForTv >= timePerEpisode)
            {
                double timeLeft = Math.Ceiling(breakTimeLeftForTv - timePerEpisode);

                Console.WriteLine($"You have enough time to watch {tvShowName} and left with {timeLeft} minutes free time.");
            }

            else if (breakTimeLeftForTv < timePerEpisode)
            {
                double timeNeeded = Math.Ceiling(timePerEpisode - breakTimeLeftForTv);

                Console.WriteLine($"You don't have enough time to watch {tvShowName}, you need {timeNeeded} more minutes.");
            }

        }
    }
}
