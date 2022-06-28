using System;

namespace OneToNine
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 9)
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
