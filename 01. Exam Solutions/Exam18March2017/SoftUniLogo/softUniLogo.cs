using System;
namespace SoftUniLogo
{
    class softUniLogo
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());

            int h = 4 * n - 2;
            int w = 12 * n - 5;

            int ctrUp = 0;
            int dots = (w - 1) / 2;
            int dotsDown = 2;
            int ctrDots = 0;
            int ctr = 0;
            int upRows = n * 2;
            int downRows1 = n - 2;
            int points = n * 3 - 1;

            for (int i = 1; i <= h; i++)
            {
                if (i >= 1 && i <= upRows)
                {
                    Console.WriteLine(new string('.', dots - ctrDots) +
                        new string('#', 1 + ctrUp) + new string('.', dots - ctrDots));
                    ctrUp += 6;
                    ctrDots += 3;
                }
                else if (i > upRows && i <= upRows + downRows1)
                {
                    Console.Write("|");
                    Console.Write(new string('.', dotsDown + ctr) +
                        new string('#', w - dotsDown * 2 - ctr * 2 - 2) +
                        new string('.', dotsDown + ctr));
                    Console.WriteLine(".");
                    ctr += 3;

                }
                else if (i >= upRows + downRows1 && i <= h - 1)
                {
                    Console.WriteLine("|" + new string('.', points - 3) +
                        new string('#', w - 2 - 2 * (points - 3)) +
                        new string('.', points - 3) + ".");
                }
                else if (i == h)
                {
                    Console.WriteLine("@" + new string('.', points - 3) +
                        new string('#', w - 2 - 2 * (points - 3)) +
                        new string('.', points - 3) + ".");
                }
            }
        }
    }
}
