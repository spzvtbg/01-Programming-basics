using System;
namespace SpecialNumbers
{
    class specialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            if (number % a == 0 && number % b == 0 && number % c == 0 && number % d == 0)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
