using System;

namespace BachelorParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int performerPrice = int.Parse(Console.ReadLine());
            string input = "";
            int entrancePrice = 0;
            int totalGuests = 0;
            int totalMoney = 0;

            while (input != "The restaurant is full")
            {
                input = Console.ReadLine();
                if (input == "The restaurant is full")
                {
                    break;
                }

                int groupCount = int.Parse(input);

                if (groupCount < 5)
                {
                    entrancePrice = groupCount * 100;
                    totalGuests += groupCount;
                    totalMoney += entrancePrice;
                }
                else if (groupCount >= 5)
                {
                    entrancePrice = groupCount * 70;
                    totalGuests += groupCount;
                    totalMoney += entrancePrice;
                }

                

                
            }
            if (totalMoney >= performerPrice)
            {
                Console.WriteLine($"You have {totalGuests} guests and {totalMoney - performerPrice} leva left.");
            }
            else if (totalMoney < performerPrice)
            {
                Console.WriteLine($"You have {totalGuests} guests and {totalMoney} leva income, but no singer.");
            }

        }
    }
}
