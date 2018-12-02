using System;
namespace Histogram
{
    class histogram
    {
        static void Main()
        {
            double n = 0.00;
            n = double.Parse(Console.ReadLine());
            double sum200 = 0;
            double sum400 = 0;
            double sum600 = 0;
            double sum800 = 0;
            double sum1000 = 0;
            double Procent1 = 0;
            double Procent2 = 0;
            double Procent3 = 0;
            double Procent4 = 0;
            double Procent5 = 0;
            for (double i = 0; i < n; i++)
            {
                double Number = double.Parse(Console.ReadLine());
                if (Number >= 0 && Number < 200)
                {
                    sum200 = sum200 + 1;
                }
                if (Number >= 200 && Number < 400)
                {
                    sum400 = sum400 + 1;
                }
                if (Number >= 400 && Number < 600)
                {
                    sum600 = sum600 + 1;
                }
                if (Number >= 600 && Number < 800)
                {
                    sum800 = sum800 + 1;
                }
                if (Number >= 800)
                {
                    ++sum1000;
                }
                Procent1 = (100 / n) * sum200;
                Procent2 = (100 / n) * sum400;
                Procent3 = (100 / n) * sum600;
                Procent4 = (100 / n) * sum800;
                Procent5 = (100 / n) * sum1000;
            }
            Console.WriteLine("{0:f2}%", Procent1);
            Console.WriteLine("{0:f2}%", Procent2);
            Console.WriteLine("{0:f2}%", Procent3);
            Console.WriteLine("{0:f2}%", Procent4);
            Console.WriteLine("{0:f2}%", Procent5);
        }
    }
}
