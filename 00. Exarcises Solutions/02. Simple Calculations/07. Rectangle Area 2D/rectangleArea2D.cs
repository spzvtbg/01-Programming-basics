using System;
namespace RectangleArea2D
{
    class rectangleArea2D
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);

            Console.WriteLine("Rectangel-Area = " + (x * y));
            Console.WriteLine("Perimeter = " + ((x + y) * 2));
        }
    }
}
