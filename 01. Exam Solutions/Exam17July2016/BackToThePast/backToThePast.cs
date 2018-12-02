using System;
namespace BackToThePast
{
    class backToThePast
    {
        static void Main()
        {
            double legacy = double.Parse(Console.ReadLine());
            int lifeToYear = int.Parse(Console.ReadLine());

            double moneyLeft = legacy;
            int oddYears = 0;

            for (int i = 1800; i <= lifeToYear; i++)
            {
                if (i % 2 != 0)
                {
                    moneyLeft -= (12000 + (18 + oddYears) * 50);
                }
                else
                {
                    moneyLeft -= 12000;
                }
                oddYears++;
            }

            if (moneyLeft >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.",
                    moneyLeft);
            }
            else
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.",
                    Math.Abs(moneyLeft));
            }
        }
    }
}
