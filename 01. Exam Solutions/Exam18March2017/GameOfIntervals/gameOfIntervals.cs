using System;
namespace GameOfIntervals
{
    class gameOfIntervals
    {
        static void Main()
        {
            sbyte number = sbyte.Parse(Console.ReadLine());

            double ctr2 = 0;
            double ctr3 = 0;
            double ctr4 = 0;
            double ctr5 = 0;
            double ctr10 = 0;
            double invalid = 0;
            double pro = 0.0;
            double result = 0;
            double sum = 0;

            for (int i = 1; i <= number; i++)
            {

                sbyte n = sbyte.Parse(Console.ReadLine());

                if (n >= 0 && n < 10)
                {
                    ctr2++;
                    result = n * 0.2;
                    sum += result;
                }
                else if (n >= 10 && n < 20)
                {
                    ctr3++;
                    result = n * 0.3;
                    sum += result;
                }
                else if (n >= 20 && n < 30)
                {
                    ctr4++;
                    result = n * 0.4;
                    sum += result;
                }
                else if (n >= 30 && n < 40)
                {
                    ctr5++;
                    result = 50;
                    sum += result;
                }
                else if (n >= 40 && n <= 50)
                {
                    ctr10++;
                    result = 100;
                    sum += result;
                }
                else
                {
                    invalid++;
                    sum /= 2;
                }

            }
            Console.WriteLine($"{sum:0.00}");
            Console.WriteLine($"From 0 to 9: {(ctr2 / number * 100):0.00}%");
            Console.WriteLine($"From 10 to 19: {(ctr3 / number * 100):0.00}%");
            Console.WriteLine($"From 20 to 29: {(ctr4 / number * 100):0.00}%");
            Console.WriteLine($"From 30 to 39: {(ctr5 / number * 100):0.00}%");
            Console.WriteLine($"From 40 to 50: {(ctr10 / number * 100):0.00}%");
            Console.WriteLine($"Invalid numbers: {(invalid / number * 100):0.00}%");
        }
    }
}
