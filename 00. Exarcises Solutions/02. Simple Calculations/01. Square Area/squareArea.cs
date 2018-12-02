using System;
namespace SquareArea
{
    class squareArea
    {
        static void Main()
        {
            Console.WriteLine("a=");

            var a = int.Parse(Console.ReadLine());
            var area = a * a;

            Console.WriteLine("square= ");
            Console.WriteLine(area);
        }
    }
}
