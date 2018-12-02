using System;
namespace RadiansToDegrees
{
    class radiansToDegrees
    {
        static void Main()
        {
            double rad = double.Parse(Console.ReadLine());
            double grad = Math.Round((rad * 180) / Math.PI);

            Console.WriteLine(grad);
        }
    }
}
