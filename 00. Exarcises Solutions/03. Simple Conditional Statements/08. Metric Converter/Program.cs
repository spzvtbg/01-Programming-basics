using System;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num = double.Parse(Console.ReadLine());
            string Metric = Console.ReadLine();
            string ToMetric = Console.ReadLine();

            if (Metric == "mm")
            {
                Num = Num / 1000;
            }
            else if (Metric == "cm")
            {
                Num = Num / 100;
            }
            else if (Metric == "mi")
            {
                Num = Num / 0.000621371192;
            }
            else if (Metric == "in")
            {
                Num = Num / 39.3700787;
            }
            else if (Metric == "km")
            {
                Num = Num / 0.001;
            }
            else if (Metric == "ft")
            {
                Num = Num / 3.2808399;
            }
            else if (Metric == "yd")
            {
                Num = Num / 1.0936133;
            }
            if (ToMetric == "mm")
            {
                Num = Num * 1000;
            }
            else if (ToMetric == "cm")
            {
                Num = Num * 100;
            }
            else if (ToMetric == "mi")
            {
                Num = Num * 0.000621371192;
            }
            else if (ToMetric == "in")
            {
                Num = Num * 39.3700787;
            }
            else if (ToMetric == "km")
            {
                Num = Num * 0.001;
            }
            else if (ToMetric == "ft")
            {
                Num = Num * 3.2808399;
            }
            else if (ToMetric == "yd")
            {
                Num = Num * 1.0936133;
            }
            Console.WriteLine("{0} {1}", Num, ToMetric);
        }
    }
}
