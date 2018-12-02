using System;
namespace DateAfter5Days
{
    class dateAfter5Days
    {
        static void Main()
        {
            int Day = int.Parse(Console.ReadLine());
            int Month = int.Parse(Console.ReadLine());
            DateTime AfterFiveDays = new DateTime(2017, Month, Day).AddDays(5);
            Console.WriteLine(AfterFiveDays.ToString("d.MM"));
        }
    }
}
