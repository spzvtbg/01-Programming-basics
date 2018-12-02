using System;
namespace ChristmasHat
{
    class christmasHat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char star = '*';
            char dash = '-';
            int rows = 2 * n + 5 - 2;
            int dots = (((4 * n) + 1) - 3) / 2 - 1;
            int dashes = 1;
            Console.Write(new string(dot, (((4 * n) + 1) - 3) / 2));
            Console.Write(new string('/', 1) + new string('|', 1) + new string('\\', 1));
            Console.WriteLine(new string(dot, (((4 * n) + 1) - 3) / 2));
            Console.Write(new string(dot, (((4 * n) + 1) - 3) / 2));
            Console.Write(new string('\\', 1) + new string('|', 1) + new string('/', 1));
            Console.WriteLine(new string(dot, (((4 * n) + 1) - 3) / 2));
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(new string('.', dots + 1) +
                        new string('*', 3) +
                        new string('.', dots + 1));
                }
                if (i > 1 && i <= rows - 3)
                {
                    Console.WriteLine(new string('.', dots) + "*" +
                        new string('-', dashes) + "*" +
                        new string('-', dashes) + "*" +
                        new string('.', dots));
                    dashes += 1;
                    dots--;
                }
                if (i == rows - 2 || i == rows)
                {
                    Console.WriteLine(new string('*', 4 * n + 1));
                }
                if (i == rows - 1)
                {
                    for (int j = 1; j <= (4 * n + 1) / 2; j++)
                    {
                        Console.Write("*" + ".");
                    }
                    Console.WriteLine("*");
                }
            }
        }
    }
}
