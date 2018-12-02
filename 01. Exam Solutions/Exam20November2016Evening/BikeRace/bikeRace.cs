using System;
namespace BikeRace
{
    class bikeRace
    {
        static void Main()
        {
            var JuniorCyclists = double.Parse(Console.ReadLine());
            var SeniorCyclists = double.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();
            var juniorsTaksa = 0.00;
            var seniorsTaaksa = 0.00;
            var gatheredMoney = 0.00;
            var razhodi = gatheredMoney - (5.00 / 100.00 * gatheredMoney);
            var totalEverything = 0.00;
            var allParticipants = JuniorCyclists + SeniorCyclists;
            switch (traceType)
            {
                case "trail":
                    juniorsTaksa += 5.50;
                    seniorsTaaksa += 7.00;
                    gatheredMoney = ((JuniorCyclists * juniorsTaksa) + (SeniorCyclists * seniorsTaaksa));
                    razhodi = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - razhodi;
                    break;
                case ("cross-country"):
                    juniorsTaksa += 8.00;
                    seniorsTaaksa += 9.50;
                    gatheredMoney = ((JuniorCyclists * juniorsTaksa) + (SeniorCyclists * seniorsTaaksa));
                    razhodi = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - razhodi;
                    if (allParticipants >= 50.00)
                    {
                        totalEverything = (totalEverything - (25.00 / 100.00 * totalEverything));
                    }
                    break;
                case ("downhill"):
                    juniorsTaksa += 12.25;
                    seniorsTaaksa += 13.75;
                    gatheredMoney = ((JuniorCyclists * juniorsTaksa) + (SeniorCyclists * seniorsTaaksa));
                    razhodi = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - razhodi;
                    break;
                case ("road"):
                    juniorsTaksa += 20.00;
                    seniorsTaaksa += 21.50;
                    gatheredMoney = ((JuniorCyclists * juniorsTaksa) + (SeniorCyclists * seniorsTaaksa));
                    razhodi = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - razhodi;
                    break;
            }
            Console.WriteLine("{0:f2}", totalEverything);
        }
    }
}
