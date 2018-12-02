using System;
namespace PointInFigure
{
    class pointInFigure
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y < -5 || y > 3 || x < 2 || x > 12 ||
                (x > 10 && y < -3) ||
                (x > 10 && y > 1) ||
                (x < 4 && y < -3) ||
                (x < 4 && y > 1))
            {
                Console.WriteLine("out");
            }
            else
            {
                Console.WriteLine("in");
            }
        }
    }
}
