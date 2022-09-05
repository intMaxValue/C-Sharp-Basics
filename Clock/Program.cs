using System;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (h < 10 && m < 10)
                    {
                        Console.WriteLine($"0{h}:0{m}");
                    }
                    else if (h < 10 && m >= 10)
                    {
                        Console.WriteLine($"0{h}:{m}");
                    }
                    else if (h >= 10 && m < 10)
                    {
                        Console.WriteLine($"{h}:0{m}");
                    }
                    else
                    {
                        Console.WriteLine($"{h}:{m}");
                    }
                    
                }
                
            }
        }
    }
}
