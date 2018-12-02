using System;
namespace WorkHours
{
    class workHours
    {
        static void Main()
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int workHours = workers * 8 * days;

            int hoursDiff = 0;
            int penalties = 0;

            if (workHours >= hoursNeeded)
            {
                hoursDiff = workHours - hoursNeeded;
                Console.WriteLine($"{hoursDiff} hours left");
            }
            else
            {
                hoursDiff = hoursNeeded - workHours;
                penalties = hoursDiff * days;
                Console.WriteLine($"{hoursDiff} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
