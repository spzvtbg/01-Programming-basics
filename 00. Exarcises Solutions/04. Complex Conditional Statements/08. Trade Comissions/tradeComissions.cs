using System;
namespace TradeComissions
{
    class tradeComissions
    {
        static void Main()
        {
            string town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double comission = 0;
            if (town == "sofia" && sales >= 0)
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 8 / 100;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (town == "varna" && sales >= 0)
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (town == "plovdiv" && sales >= 0)
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (town != "sofia" || town != "plovdiv" || town != "varna" || sales < 0)
            {
                Console.WriteLine("error");
            }
        }
    }
}
