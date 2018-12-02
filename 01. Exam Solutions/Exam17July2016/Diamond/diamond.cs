using System;
namespace Diamond
{
    class diamond
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int collons = 5 * size;
            int rows = 3 * size + 2;
            int point = 0;
            int point2 = 1;
            int stars = size - 2;
            int lastpoints = (collons - stars) / 2;
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string('.', size) +
                        new string('*', collons - 2 * size) +
                        new string('.', size));
                }
                if (i >= 2 && i <= size)
                {
                    Console.WriteLine(new string('.', size - 1 - point) + "*" +
                        new string('.', collons - 2 * size + point * 2) + "*" +
                        new string('.', size - 1 - point));
                    point++;
                }
                if (i == size + 1)
                {
                    Console.WriteLine(new string('*', collons));
                }
                if (i > size + 1 && i <= rows - 1)
                {
                    Console.WriteLine(new string('.', point2) + "*" +
                         new string('.', collons - 4) + "*" +
                         new string('.', point2));
                    point2++;
                    collons -= 2;
                }
                if (i == rows)
                {
                    Console.WriteLine(new string('.', lastpoints) +
                        new string('*', stars) +
                        new string('.', lastpoints));
                }
            }
        }
    }
}
