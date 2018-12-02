using System;
namespace Cups
{
    class cups
    {
        static void Main()
        {
            int neededCups = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            double oneCup = 5.00;
            double cupPrice = 4.2;
            int workHoursForDay = 8;

            int allWorkHours = workDays * numberOfWorkers * workHoursForDay;
            double cupsCuantity = Math.Truncate(allWorkHours / oneCup);
            double win = cupsCuantity * cupPrice - neededCups * cupPrice;

            if (win >= 0)
            {
                Console.WriteLine($"{win:0.00} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {Math.Abs(win):0.00}");
            }
        }
    }
}
