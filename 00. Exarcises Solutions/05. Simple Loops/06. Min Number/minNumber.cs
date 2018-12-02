using System;
namespace MinNumber
{
    class minNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
