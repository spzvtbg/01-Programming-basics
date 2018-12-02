using System;
namespace RhombusOfStars
{
    class rhombusOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            if (n > 1)
            {
                int space = n - 1;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string(' ', space));
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    space--;
                }
                for (int i = 1; i < n; i++)
                {
                    Console.Write(new string(' ', i));
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
