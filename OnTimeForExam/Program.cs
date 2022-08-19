using System;

namespace OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExamStarts = int.Parse(Console.ReadLine());
            int minuteExamStarts = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int examStartInMinutes = (60 * hourExamStarts) + minuteExamStarts;
            int arrivalInMinutes = (60 * hourOfArrival) + minuteOfArrival;

            int lateWithHours = (arrivalInMinutes - examStartInMinutes) / 60;
            int lateWithMinutes = (arrivalInMinutes - examStartInMinutes) % 60;

            int earlyWithHours = (examStartInMinutes - arrivalInMinutes) / 60;
            int earlyWithMinutes = (examStartInMinutes - arrivalInMinutes) % 60;

            if (arrivalInMinutes > examStartInMinutes)
            {
                Console.WriteLine("Late");
            }
            else if (arrivalInMinutes == examStartInMinutes) 
            {
                Console.WriteLine("On time");
            }
            if (earlyWithMinutes <= 30 && earlyWithMinutes > 0 && earlyWithHours == 0)
            {
                Console.WriteLine("On time");
            }
            else if (earlyWithMinutes > 30 || earlyWithHours > 0)
            {
                Console.WriteLine("Early");
            }


            if (arrivalInMinutes != examStartInMinutes)
            {

                if (arrivalInMinutes > examStartInMinutes)
                {
                    if (lateWithHours == 0)
                    {
                        Console.WriteLine($"{lateWithMinutes} minutes after the start");
                    }
                    else if (lateWithHours > 0 && lateWithMinutes < 10)
                    {
                        Console.WriteLine($"{lateWithHours}:0{lateWithMinutes} hours after the start");
                    }
                    else if (lateWithHours > 0 && lateWithMinutes >= 10)
                    {
                        Console.WriteLine($"{lateWithHours}:{lateWithMinutes} hours after the start");
                    }
                }

                if (arrivalInMinutes < examStartInMinutes)
                {
                    if (earlyWithHours == 0)
                    {
                        Console.WriteLine($"{earlyWithMinutes} minutes before the start");
                    }
                    else if (earlyWithHours > 0 && earlyWithMinutes < 10)
                    {
                        Console.WriteLine($"{earlyWithHours}:0{earlyWithMinutes} hours before the start");
                    }
                    else if (earlyWithHours > 0 && earlyWithMinutes >= 10)
                    {
                        Console.WriteLine($"{earlyWithHours}:{earlyWithMinutes} hours before the start");
                    }
                }

            }

        }
    }
}
