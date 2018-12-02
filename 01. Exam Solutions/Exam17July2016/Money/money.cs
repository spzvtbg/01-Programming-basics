using System;
namespace _01.Money
{
    class Program
    {
        static void Main()
        {
            //1 Bitkon = 1168lv.
            //1 Juan = 0.15usd.
            //1 usd = 1.76lv
            //1 eur = 1.95lv

            double bitkon = double.Parse(Console.ReadLine());

            double juan = double.Parse(Console.ReadLine());

            double provision = double.Parse(Console.ReadLine());

            double leva = bitkon * 1168 / 1.95;

            double usd = juan * 0.15 * 1.76 / 1.95;

            double sum = (leva + usd) - (leva + usd) * (provision / 100);

            Console.WriteLine(sum);
        }
    }
}
