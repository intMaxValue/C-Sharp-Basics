﻿using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double cm = 2.54;
            Console.WriteLine(inch * cm);
        }
    }
}
