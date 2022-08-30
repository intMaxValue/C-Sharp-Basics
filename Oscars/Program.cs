using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());

            double totalPoints = pointsFromAcademy;

            for (int i = 0; i < juryCount; i++)
            {
                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:F1}!");
                    break;
                }

                string jury = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                int juryName = jury.Length;
                totalPoints += juryName * grade / 2;
            }

            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - totalPoints:F1} more!");

            }

        }
    }
}
