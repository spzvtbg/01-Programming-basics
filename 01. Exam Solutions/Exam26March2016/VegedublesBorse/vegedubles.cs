using System;
namespace VegedublesBorse
{
    class vegedubles
    {
        static void Main()
        {
            double PraiceVegdubles = double.Parse(Console.ReadLine());
            double PraiceFruits = double.Parse(Console.ReadLine());
            double AllVegdublesKg = double.Parse(Console.ReadLine());
            double AllFruitsKg = double.Parse(Console.ReadLine());
            double WinVegdubles = PraiceVegdubles * AllVegdublesKg;
            double WinFruits = PraiceFruits * AllFruitsKg;
            double InEuro = (WinVegdubles + WinFruits) / 1.94;
            Console.WriteLine(InEuro);
        }
    }
}
