using System;
namespace TriangleArea
{
    class triangleArea
    {
        static void Main()
        {
            double c = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = Math.Round((c * h / 2), 2);

            Console.WriteLine("Triangle  Area = {0}", area);
        }
    }
}
