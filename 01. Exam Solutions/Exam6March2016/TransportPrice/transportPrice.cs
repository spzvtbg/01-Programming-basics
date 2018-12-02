using System;
namespace TransportPrice
{
    class transportPrice
    {
        static void Main()
        {
            double kmToDriving = double.Parse(Console.ReadLine());
            string DayOrNight = Console.ReadLine();

            DayOrNight = DayOrNight.ToLower();

            double TaxiStartTarif = 0.70;
            double TaxiDayTarif = 0.79;
            double TaxiNightTarif = 0.90;

            double BusTarif = 0.09;

            double TrainTarif = 0.06;

            if (!(kmToDriving > 0 && kmToDriving <= 5000))
            {
                Console.WriteLine("Invalid distance.");
            }
            if (!(DayOrNight == "day") && !(DayOrNight == "night"))
            {
                Console.WriteLine("Invalid day part of time.");
            }
            if (DayOrNight == "day")
            {
                if (kmToDriving < 20)
                {
                    Console.WriteLine(Math.Round(TaxiStartTarif + kmToDriving * TaxiDayTarif, 2));
                }
                if (kmToDriving >= 20 && kmToDriving < 100)
                {
                    Console.WriteLine(Math.Round(BusTarif * kmToDriving, 2));
                }
                if (kmToDriving >= 100 && kmToDriving <= 5000)
                {
                    Console.WriteLine(Math.Round(TrainTarif * kmToDriving, 2));
                }
            }
            if (DayOrNight == "night")
            {
                if (kmToDriving < 20)
                {
                    Console.WriteLine(Math.Round(TaxiStartTarif + kmToDriving * TaxiNightTarif, 2));
                }
                if (kmToDriving >= 20 && kmToDriving < 100)
                {
                    Console.WriteLine(Math.Round(BusTarif * kmToDriving, 2));
                }
                if (kmToDriving >= 100 && kmToDriving <= 5000)
                {
                    Console.WriteLine(Math.Round(TrainTarif * kmToDriving, 2));
                }
            }
        }
    }
}
