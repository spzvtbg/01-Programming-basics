using System;
namespace Flowers
{
    class flowers
    {
        static void Main()
        {
            double chrysanthemums = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();//[Y – да / N - не]
            double PriceCh = 0;
            double PriceR = 0;
            double PriceT = 0;
            double hollydays = 0.15;
            if (season == "Spring" || season == "Summer")
            {
                if (day == "Y")
                {
                    PriceCh = (2.00 + 2.00 * 0.15) * chrysanthemums;
                    PriceR = (4.10 + 4.10 * 0.15) * roses;
                    PriceT = (2.50 + 2.50 * 0.15) * tulips;
                }
                else
                {
                    PriceCh = 2.00 * chrysanthemums;
                    PriceR = 4.10 * roses;
                    PriceT = 2.50 * tulips;
                }
            }
            if (season == "Autumn" || season == "Winter")
            {
                if (day == "Y")
                {
                    PriceCh = (3.75 + 3.75 * 0.15) * chrysanthemums;
                    PriceR = (4.50 + 4.50 * 0.15) * roses;
                    PriceT = (4.15 + 4.15 * 0.15) * tulips;
                }
                else
                {
                    PriceCh = 3.75 * chrysanthemums;
                    PriceR = 4.50 * roses;
                    PriceT = 4.15 * tulips;
                }
            }
            double EndPrice = PriceCh + PriceR + PriceT;
            if (tulips > 7 && season == "Spring")
            {
                EndPrice = EndPrice - EndPrice * 0.05;
            }
            if (roses >= 10 && season == "Winter")
            {
                EndPrice = EndPrice - EndPrice * 0.10;
            }
            double TotalFlowers = chrysanthemums + roses + tulips;
            if (TotalFlowers > 20)
            {
                EndPrice = EndPrice - EndPrice * 0.20;
            }
            Console.WriteLine("{0:f2}", EndPrice + 2);
        }
    }
}
