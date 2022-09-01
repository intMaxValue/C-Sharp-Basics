using System;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tournamentCount = int.Parse(Console.ReadLine());
            double startPoints = int.Parse(Console.ReadLine());

            string placement = "";
            double totalPoints = startPoints;
            double tournamentWon = 0;

            for (int i = 0; i < tournamentCount; i++)
            {
                placement = Console.ReadLine();

                if (placement == "W")
                {
                    totalPoints += 2000;
                    tournamentWon++;
                }
                else if (placement == "F")
                {
                    totalPoints += 1200;
                }
                else if (placement == "SF")
                {
                    totalPoints += 720;
                }

            }

            double averagePoints = (totalPoints - startPoints) / tournamentCount;
            double percentOfTournamentsWon = (tournamentWon / tournamentCount) * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentOfTournamentsWon:F2}%");
        }
    }
}
