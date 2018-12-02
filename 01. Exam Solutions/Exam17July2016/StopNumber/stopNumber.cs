using System;
namespace StopNumber
{
    class stopNumber
    {
        static void Main()
        {
            int fromN = int.Parse(Console.ReadLine());
            int toM = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            for (int a = toM; a >= fromN; a--)
            {
                if (a == stop && a % 2 == 0 && a % 3 == 0)
                {
                    break;
                }
                if (a % 2 == 0 && a % 3 == 0)
                {
                    Console.Write(a);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
