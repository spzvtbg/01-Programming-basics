using System;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNow = int.Parse(Console.ReadLine());
            int minutesNow = int.Parse(Console.ReadLine());
            TimeSpan timeNow = new TimeSpan(hoursNow, minutesNow, 0).Add(TimeSpan.FromMinutes(15));
            if (timeNow.Minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", timeNow.Hours, timeNow.Minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", timeNow.Hours, timeNow.Minutes);
            }
        }
    }
}
