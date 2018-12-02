using System;
namespace CelsiusToFahrenheit
{
    class celsiusToFahrenheit
    {
        static void Main()
        {
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine("C = {0:0.00}", (C * 1.8 + 32));
        }
    }
}
