using System;
namespace _16.SquareOfStars
{
    class squareOfStars
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if (i == 0 || i == N - 1)
                    Console.WriteLine(new String('*', N));
                else
                    Console.WriteLine("*{0}*", new string(' ', N - 2));
            }
        }
    }
}
