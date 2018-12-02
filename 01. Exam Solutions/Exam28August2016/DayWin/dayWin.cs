using System;
namespace DayWin
{
    class dayWin
    {
        static void Main()
        {
            double WorkDays = double.Parse(Console.ReadLine());
            double DayWin = double.Parse(Console.ReadLine());
            double DollarLeva = double.Parse(Console.ReadLine());
            double MonthWin = WorkDays * DayWin;
            double bonus = MonthWin * 2.5;
            double YearWin = MonthWin * 12 + bonus;
            double ClearWinInYear = YearWin - YearWin * 25 / 100;
            double InLeva = ClearWinInYear * DollarLeva;
            double ToOneDayMidleWin = InLeva / 365;
            Console.WriteLine("{0:f2}", ToOneDayMidleWin);
        }
    }
}
