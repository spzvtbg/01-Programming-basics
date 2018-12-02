using System;
namespace TrapeziodArea
{
    class trapeziodArea
    {
        static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Trapezoid-Area =" + ((b1 + b2) * (h / 2)));
        }
    }
}
