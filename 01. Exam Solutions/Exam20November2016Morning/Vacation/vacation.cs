using System;
namespace Vacation
{
    class vacation
    {
        static void Main()
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();
            double adultPrice = 0;
            double studentPrice = 0;
            double nightsPrice = 82.99 * nights;
            if (adults + students > 50)
            {
                adultPrice = 24.99 * 0.5 * adults;
                studentPrice = 14.99 * 0.5 * students;
            }
            if (transport == "train")
            {
                if (adults + students > 50)
                {
                    adultPrice = 24.99 * 0.5 * adults;
                    studentPrice = 14.99 * 0.5 * students;
                }
                else
                {
                    adultPrice = 24.99 * adults;
                    studentPrice = 14.99 * students;
                }
            }
            else if (transport == "bus")
            {
                adultPrice = 32.50 * adults;
                studentPrice = 28.50 * students;
            }
            else if (transport == "boat")
            {
                adultPrice = 42.99 * adults;
                studentPrice = 39.99 * students;
            }
            else if (transport == "airplane")
            {
                adultPrice = 70.00 * adults;
                studentPrice = 50.00 * students;
            }
            double commission = ((adultPrice + studentPrice) * 2 + nightsPrice) * 0.1;
            double allPrice = ((adultPrice + studentPrice) * 2 + nightsPrice) + commission;
            Console.WriteLine($"{allPrice:f2}");
        }
    }
}
