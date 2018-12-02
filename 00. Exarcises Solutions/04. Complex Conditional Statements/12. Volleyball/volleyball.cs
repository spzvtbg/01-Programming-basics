using System;
namespace Volleyball
{
    class volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine().ToLower();
            double holyday = double.Parse(Console.ReadLine());
            double away = double.Parse(Console.ReadLine());
            double NormalPlayW = (48 - away) * 3 / 4;
            double NormalPlayH = holyday * 2 / 3;
            double leap15 = 15 / 100;
            if (year == "normal")
            {
                double play = NormalPlayW + NormalPlayH + away;
                Console.WriteLine(Math.Truncate(play));
            }
            else if (year == "leap")
            {
                double play = NormalPlayW + NormalPlayH + away;
                double leap = play + play * 15 / 100;
                Console.WriteLine(Math.Truncate(leap));
            }
        }
    }
}
