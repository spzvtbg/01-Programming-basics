using System;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int Scour = int.Parse(Console.ReadLine());
            double Bonus = 0;

            if (Scour <= 100)
            {
                Bonus = 5;
            }
            else
            {
                Bonus = Scour * 0.2;
            }
            if (Scour > 1000)
            {
                Bonus = Scour * 0.1;
            }
            if (Scour % 2 == 0)
            {
                Bonus = Bonus + 1;
            }
            if (Scour % 10 == 5)
            {
                Bonus += 2;
            }
            Console.WriteLine(Bonus);
            Console.WriteLine(Bonus + Scour);
        }
    }
}
