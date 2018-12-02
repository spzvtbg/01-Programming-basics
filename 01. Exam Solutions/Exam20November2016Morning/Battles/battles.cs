using System;
namespace Battles
{
    class battles
    {
        static void Main()
        {
            int pokemonscount1 = int.Parse(Console.ReadLine());
            int pokemonscount2 = int.Parse(Console.ReadLine());
            int maxbattles = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= pokemonscount1; i++)
            {
                for (int j = 1; j <= pokemonscount2; j++)
                {

                    if (count == maxbattles)
                    {
                        break;
                    }

                    Console.Write("({0} <-> {1}) ", i, j);
                    count++;
                }
            }
        }
    }
}
