using System;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            int peoplePerGroup = 0;
            int totalPeopleCount = 0;

            double musala = 0;
            double monblan = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;

            double musalaTotalPeople = 0;
            double monblanTotalPeople = 0;
            double kilimanjaroTotalPeople = 0;
            double k2TotalPeople = 0;
            double everestTotalPeople = 0;

            for (int i = 0; i < groupCount; i++)
            {
                peoplePerGroup = int.Parse(Console.ReadLine());
                totalPeopleCount += peoplePerGroup;

                if (peoplePerGroup <= 5)
                {
                    musala++;
                    musalaTotalPeople += peoplePerGroup;
                }
                else if (peoplePerGroup > 5 && peoplePerGroup <= 12)
                {
                    monblan++;
                    monblanTotalPeople += peoplePerGroup;
                }
                else if (peoplePerGroup > 12 && peoplePerGroup <= 25)
                {
                    kilimanjaro++;
                    kilimanjaroTotalPeople += peoplePerGroup;
                }
                else if (peoplePerGroup >25 && peoplePerGroup <= 40)
                {
                    k2++;
                    k2TotalPeople += peoplePerGroup;
                }
                else if (peoplePerGroup > 40)
                {
                    everest++;
                    everestTotalPeople += peoplePerGroup;
                }

            }

            Console.WriteLine($"{musalaTotalPeople / totalPeopleCount * 100:F2}%");
            Console.WriteLine($"{monblanTotalPeople / totalPeopleCount * 100:F2}%");
            Console.WriteLine($"{kilimanjaroTotalPeople / totalPeopleCount * 100:F2}%");
            Console.WriteLine($"{k2TotalPeople / totalPeopleCount * 100:F2}%");
            Console.WriteLine($"{everestTotalPeople / totalPeopleCount * 100:F2}%");
        }
    }
}
