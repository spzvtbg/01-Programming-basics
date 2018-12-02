using System;
namespace SquareOfStars
{
    class squareOfStars
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if ((i == 1) && (i == N) && (j == 1) && (j == N))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
