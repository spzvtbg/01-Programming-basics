using System;
namespace SoftUniCamp
{
    class softUniCamp
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());
            int[] peopleINgroop = new int[groups];
            int auto = 0;
            int van = 0;
            int litleBus = 0;
            int Bus = 0;
            int train = 0;
            double allPeople = 0;
            for (int i = 0; i < peopleINgroop.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peopleINgroop[i] = people;
                if (people <= 5)
                {
                    auto += peopleINgroop[i];
                }
                if (people >= 6 && people <= 12)
                {
                    van += peopleINgroop[i];
                }
                if (people >= 13 && people <= 25)
                {
                    litleBus += peopleINgroop[i];
                }
                if (people >= 26 && people <= 40)
                {
                    Bus += peopleINgroop[i];
                }
                if (people >= 41)
                {
                    train += peopleINgroop[i];
                }
                allPeople += peopleINgroop[i];
            }
            Console.WriteLine("{0:f2}%", (auto / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (van / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (litleBus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (Bus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (train / allPeople) * 100);
        }
    }
}
