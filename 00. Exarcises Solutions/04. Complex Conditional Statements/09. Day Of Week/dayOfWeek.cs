using System;
namespace DayOfWeek
{
    class dayOfWeek
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string[] days = { "error", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (num <= 0 || num > 7)
            {
                Console.WriteLine("error");
            }
            for (int n = 0; n == days.Length;)
            {
                n = num;
            }
            if (num > 0 && num <= 7)
            {
                Console.WriteLine(days[num]);
            }
        }
    }
}
