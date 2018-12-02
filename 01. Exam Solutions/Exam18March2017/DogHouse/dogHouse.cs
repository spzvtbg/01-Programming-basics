using System;
namespace DogHouse
{
    class dogHouse
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double widht = lenght / 2;
            double enter = (lenght / 5) * (lenght / 5);
            double lenghtLowsArea = 2 * (lenght * widht);

            double triangelArea = ((hight - widht) * widht) / 2;
            double shortLowsArea = 2 * (widht * widht) + 2 * triangelArea - enter;

            double roofArea = lenght * (lenght / 2) * 2;
            double lowsArea = lenghtLowsArea + shortLowsArea;

            double greenPaint = lowsArea / 3;
            double redPaint = roofArea / 5;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
