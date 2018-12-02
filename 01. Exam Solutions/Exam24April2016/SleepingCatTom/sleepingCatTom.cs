using System;
namespace SleepingCatTom
{
    class sleepingCatTom
    {
        static void Main()
        {
            int freeDays = int.Parse(Console.ReadLine());
            int playTimeForYear = 30000; // min
            int palyFreeDays = freeDays * 127;
            int playWorkDays = (365 - freeDays) * 63;
            int playTime = playWorkDays + palyFreeDays;
            int timeDiff = playTime - playTimeForYear;
            if (playTime > playTimeForYear)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", timeDiff / 60, timeDiff % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                    Math.Abs(timeDiff) / 60, Math.Abs(timeDiff) % 60);
            }
        }
    }
}
