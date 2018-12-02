using System;
namespace Fishland
{
    class fishland
    {
        static void Main()
        {
            double mackerel = double.Parse(Console.ReadLine());
            double sprat = double.Parse(Console.ReadLine());
            double beltedbonito = double.Parse(Console.ReadLine());
            double scad = double.Parse(Console.ReadLine());
            double clams = double.Parse(Console.ReadLine());
            double bbPrice = mackerel + mackerel * 0.6;
            double scadPrice = sprat + sprat * 0.8;
            double clamsPrice = 7.50;
            double bbSum = beltedbonito * bbPrice;
            double skadSum = scadPrice * scad;
            double clamsSum = clams * clamsPrice;
            double allSum = bbSum + skadSum + clamsSum;
            Console.WriteLine("{0:f2}", allSum);
        }
    }
}
