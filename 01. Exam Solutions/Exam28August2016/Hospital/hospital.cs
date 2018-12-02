using System;
namespace Hospital
{
    class hospital
    {
        static void Main()
        {
            int workDays = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = doctors;
            int unTreated = 0;
            int treatedSum = 0;
            int unTreatedSum = 0;
            for (int a = 1; a <= workDays; a++)
            {
                int arrivelPatients = int.Parse(Console.ReadLine());
                if (unTreatedSum > treatedSum && a % 3 == 0)
                {
                    doctors++;
                }
                if (arrivelPatients > 7)
                {
                    treated = doctors;
                    unTreated = arrivelPatients - treated;
                }
                else if (arrivelPatients <= 7)
                {
                    treated = arrivelPatients;
                    unTreated = 0;
                }
                treatedSum += treated;
                unTreatedSum += unTreated;
            }
            Console.WriteLine("Treated patients: {0}.", treatedSum);
            Console.WriteLine("Untreated patients: {0}.", unTreatedSum);
        }
    }
}
