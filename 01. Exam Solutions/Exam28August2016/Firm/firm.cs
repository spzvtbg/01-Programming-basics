using System;
namespace Firm
{
    class firm
    {
        static void Main()
        {
            int orderedHours = int.Parse(Console.ReadLine());
            int orderedDays = int.Parse(Console.ReadLine());
            int peopleWorkingOvertime = int.Parse(Console.ReadLine());
            double studing = orderedDays * 0.1;
            int overtimeHours = peopleWorkingOvertime * 2;
            double hoursToWork = Math.Truncate((orderedDays - studing) * 8 + overtimeHours * orderedDays);
            double differenceHours = hoursToWork - orderedHours;
            if (differenceHours < 0)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(differenceHours));
            }
            else
            {
                Console.WriteLine("Yes!{0} hours left.", differenceHours);
            }
        }
    }
}
