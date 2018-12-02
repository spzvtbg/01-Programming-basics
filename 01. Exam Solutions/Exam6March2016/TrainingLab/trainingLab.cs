using System;
namespace TrainingLab
{
    class trainingLab
    {
        static void Main()
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double places = (Math.Truncate(l / 1.20) * Math.Truncate((w - 1.00) / 0.70)) - 3;
            Console.WriteLine(places);
        }
    }
}
