using System;
namespace PointOnRectangleBorder
{
    class pointOnRectangleBorder
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isleft = x == x1 && y >= y1 && y <= y2;
            bool isright = x == x2 && y >= y1 && y <= y2;
            bool isdown = y == y1 && x >= x1 && x <= x2;
            bool isup = y == y2 && x >= x1 && x <= x2;

            if (isleft || isright || isdown || isup)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
