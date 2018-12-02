using System;
namespace Vacation
{
    class vacation
    {
        static void Main()
        {
            double butget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double vacantionPrice = butget;
            string plase = "";
            string destination = "";

            if (butget <= 1000)
            {
                if (season == "summer")
                {
                    vacantionPrice *= 0.65;
                    destination = "Alaska";
                }
                else if (season == "winter")
                {
                    vacantionPrice *= 0.45;
                    destination = "Morocco";
                }
                plase = "Camp";
            }
            else if (butget > 1000 && butget <= 3000)
            {
                if (season == "summer")
                {
                    vacantionPrice *= 0.80;
                    destination = "Alaska";
                }
                else if (season == "winter")
                {
                    vacantionPrice *= 0.60;
                    destination = "Morocco";
                }
                plase = "Hut";
            }
            else if (butget > 3000)
            {
                if (season == "summer")
                {
                    vacantionPrice *= 0.90;
                    destination = "Alaska";
                }
                else if (season == "winter")
                {
                    vacantionPrice *= 0.90;
                    destination = "Morocco";
                }
                plase = "Hotel";
            }
            Console.WriteLine($"{destination} - {plase} - {vacantionPrice:f2}");
        }
    }
}
