using System;
namespace SquareFrame
{
    class squareFrame
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("+");
            }
            else if (n > 1)
            {
                Console.Write("+");
                for (int col = 1; col <= n - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
                for (int row = 1; row <= n - 2; row++)
                {
                    Console.Write("|");
                    for (int col = 1; col <= n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" |");
                }
                Console.Write("+");
                for (int col = 1; col <= n - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
        }
    }
}
