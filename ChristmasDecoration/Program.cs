using System;

namespace ChristmasDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string toyName = Console.ReadLine();

            while (toyName != "Stop")
            {

                int toyPrice = 0;

                for (int i = 0; i < toyName.Length; i++)
                {
                    toyPrice += toyName[i];
                }

                toyName = Console.ReadLine();
            }
        }
    }
}
