using System;
namespace RoadTrip
{
    class roadTrip
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double expense = 0;
            string destination = "";
            string art = "";

            if (budget <= 100)
            {
                expense = season == "summer" ? budget *= 0.30 : budget *= 0.70;
                art = season == "summer" ? "Camp" : "Hotel";
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                expense = season == "summer" ? budget *= 0.40 : budget *= 0.80;
                art = season == "summer" ? "Camp" : "Hotel";
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                expense = budget * 0.90;
                art = "Hotel";
                destination = "Europe";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{art} - {expense:0.00}");
        }
    }
}
