using System;
namespace CarToGo
{
    class carToGo
    {
        static void Main()
        {
            double butget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string clas = "";
            string auto = "";
            double spend = 0;

            if (butget <= 100)
            {
                clas = "Economy class";
                if (season == "summer")
                {
                    auto = "Cabrio";
                    spend = butget * 0.35;
                }
                else if (season == "winter")
                {
                    auto = "Jeep";
                    spend = butget * 0.65;
                }
            }
            else if (butget > 100 && butget <= 500)
            {
                clas = "Compact class";
                if (season == "summer")
                {
                    auto = "Cabrio";
                    spend = butget * 0.45;
                }
                else if (season == "winter")
                {
                    auto = "Jeep";
                    spend = butget * 0.80;
                }
            }
            else
            {
                clas = "Luxury class";
                auto = "Jeep";
                spend = butget * 0.90;
            }
            Console.WriteLine($"{clas}\n{auto} - {spend:0.00}");
        }
    }
}
