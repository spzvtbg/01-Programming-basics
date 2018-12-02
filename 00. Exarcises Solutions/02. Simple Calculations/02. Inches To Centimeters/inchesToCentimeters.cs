using System;
namespace InchesToCentimeters
{
    class inchesToCentimeters
    {
        static void Main()
        {
            Console.Write("Inches = ");
            var Inch = Double.Parse(Console.ReadLine());
            var centimeters = Inch * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
