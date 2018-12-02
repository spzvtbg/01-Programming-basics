using System;
namespace NumberTable
{
    class numberTable
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var ctr = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    ctr = row + col;
                    if (ctr > n) ctr = (2 * n) - col - row;
                    Console.Write(ctr + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
