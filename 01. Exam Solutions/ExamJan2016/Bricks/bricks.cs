using System;
namespace Bricks
{
    class bricks
    {
        static void Main()
        {
            double BrickQuantity = double.Parse(Console.ReadLine());
            double NumberOfWorcker = double.Parse(Console.ReadLine());
            double CapacityOfWheelbarrow = double.Parse(Console.ReadLine());

            double NumberOfCourses = BrickQuantity / (NumberOfWorcker * CapacityOfWheelbarrow);

            Console.WriteLine("{0}", Math.Ceiling(NumberOfCourses));
        }
    }
}
