using System;
namespace HotelRoom
{
    class hotelRoom
    {
        static void Main()
        {
            string m = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
            double sums = 0;
            if (m == "may" || m == "october")
            {
                suma = 65;
                sums = 50;
                if (n > 14)
                {
                    suma -= 65 * 0.1;
                    sums -= 50 * 0.3;
                }
                else
                {
                    if (n > 7)
                    {
                        sums -= 50 * 0.05;
                    }
                }
            }
            else if (m == "june" || m == "september")
            {
                suma = 68.70;
                sums = 75.20;
                if (n > 14)
                {
                    suma -= 68.70 * 0.1;
                    sums -= 75.20 * 0.2;
                }
            }
            else if (m == "july" || m == "august")
            {
                suma = 77;
                sums = 76;
                if (n > 14)
                {
                    suma -= 77 * 0.1;
                }
            }
            double alla = suma * n;
            double alls = sums * n;
            Console.WriteLine("Apartment: {0:f2} lv.\nStudio: {1:f2} lv.", alla, alls);
        }
    }
}
