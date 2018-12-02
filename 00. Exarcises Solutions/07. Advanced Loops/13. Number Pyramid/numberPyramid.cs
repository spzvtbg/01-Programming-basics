using System;
namespace NumberPyramid
{
    class numberPyramid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int ctr = 0;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    ctr++;
                    Console.Write(ctr + " ");
                    if (ctr == n) break;
                }
                if (ctr == n) break;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
