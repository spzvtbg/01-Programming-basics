using System;
namespace TruckDriver
{
    class truckDriver
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            double kmForMonth = double.Parse(Console.ReadLine());

            double preisKm = kmForMonth;

            if (season == "spring" || season == "autumn")
            {
                if (kmForMonth <= 5000)
                {
                    preisKm *= 0.75;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    preisKm *= 0.95;
                }
                else
                {
                    preisKm *= 1.45;
                }
            }
            else if (season == "summer")
            {
                if (kmForMonth <= 5000)
                {
                    preisKm *= 0.90;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    preisKm *= 1.10;
                }
                else
                {
                    preisKm *= 1.45;
                }
            }
            else
            {
                if (kmForMonth <= 5000)
                {
                    preisKm *= 1.05;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    preisKm *= 1.25;
                }
                else
                {
                    preisKm *= 1.45;
                }
            }

            double money = preisKm * 4 * 0.90;

            Console.WriteLine($"{money:0.00}");
        }
    }
}
