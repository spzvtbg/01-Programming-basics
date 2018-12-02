using System;

namespace EvenPowersOf2
{
    class evenPowersOf2
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(n);
                    n *= 2 * 2;
                }
            }
        }
    }
}
