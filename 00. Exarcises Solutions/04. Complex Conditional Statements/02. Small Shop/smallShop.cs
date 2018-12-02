using System;
namespace SmallShop
{
    class smallShop
    {
        static void Main()
        {
            string p = Console.ReadLine().ToLower();
            string t = Console.ReadLine().ToLower();
            double q = double.Parse(Console.ReadLine());
            if (t == "sofia")
            {
                if (p == "coffee")
                {
                    Console.WriteLine(q * 0.50);
                }
                else if (p == "water")
                {
                    Console.WriteLine(q * 0.80);
                }
                else if (p == "beer")
                {
                    Console.WriteLine(q * 1.20);
                }
                else if (p == "sweets")
                {
                    Console.WriteLine(q * 1.45);
                }
                else if (p == "peanuts")
                {
                    Console.WriteLine(q * 1.60);
                }
            }
            else if (t == "plovdiv")
            {
                if (p == "coffee")
                {
                    Console.WriteLine(q * 0.40);
                }
                else if (p == "water")
                {
                    Console.WriteLine(q * 0.70);
                }
                else if (p == "beer")
                {
                    Console.WriteLine(q * 1.15);
                }
                else if (p == "sweets")
                {
                    Console.WriteLine(q * 1.30);
                }
                else if (p == "peanuts")
                {
                    Console.WriteLine(q * 1.50);
                }
            }
            else if (t == "varna")
            {
                if (p == "coffee")
                {
                    Console.WriteLine(q * 0.45);
                }
                else if (p == "water")
                {
                    Console.WriteLine(q * 0.70);
                }
                else if (p == "beer")
                {
                    Console.WriteLine(q * 1.10);
                }
                else if (p == "sweets")
                {
                    Console.WriteLine(q * 1.35);
                }
                else if (p == "peanuts")
                {
                    Console.WriteLine(q * 1.55);
                }
            }
        }
    }
}
