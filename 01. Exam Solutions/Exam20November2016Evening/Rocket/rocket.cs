using System;
namespace Rocket
{
    class rocket
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int startDot = n - 1;
            int empty = 0;
            int sideDot = n / 2;
            int stars = (n * 3) - (n + 2);
            for (int i = 1; i <= n * 4; i++)
            {
                if (i <= n)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write(new string('.', startDot) +
                        new string('/', 1) +
                        new string(' ', empty) +
                        new string('\\', 1) +
                        new string('.', startDot));
                    Console.Write(new string('.', n / 2));
                    Console.WriteLine();
                    startDot--;
                    empty += 2;
                }
                if (i == n + 1)
                {
                    Console.WriteLine(new string('.', n / 2) +
                                       new string('*', n * 2) +
                                       new string('.', n / 2));
                }
                if (i >= n + 1 && i <= n * 3)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write(new string('|', 1) +
                        new string('\\', n * 2 - 2) +
                        new string('|', 1));
                    Console.Write(new string('.', n / 2));
                    Console.WriteLine();
                }
                if (i > n * 3 + 1 && i <= (n * 3 + 1) + (n / 2))
                {
                    Console.Write(new string('.', sideDot) +
                        "/" + new string('*', stars) + "\\" +
                        new string('.', sideDot));
                    Console.WriteLine();
                    sideDot--;
                    stars += 2;
                }
            }
        }
    }
}
