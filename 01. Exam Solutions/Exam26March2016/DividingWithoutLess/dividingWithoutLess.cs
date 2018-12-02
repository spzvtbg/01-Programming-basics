using System;
namespace DividingWithoutLess
{
    class dividingWithoutLess
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double pro = 100 / n;
            double pro1 = 0;
            double pro2 = 0;
            double pro3 = 0;
            for (double i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    ++sum1;
                }
                if (number % 3 == 0)
                {
                    ++sum2;
                }
                if (number % 4 == 0)
                {
                    ++sum3;
                }
                pro1 = sum1 * pro;
                pro2 = sum2 * pro;
                pro3 = sum3 * pro;
            }
            Console.WriteLine("{0:f2}%", pro1);
            Console.WriteLine("{0:f2}%", pro2);
            Console.WriteLine("{0:f2}%", pro3);
        }
    }
}
