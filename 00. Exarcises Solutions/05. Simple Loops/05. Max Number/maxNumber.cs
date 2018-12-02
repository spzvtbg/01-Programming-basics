using System;
namespace MaxNumber
{
    class maxNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = -1000000000;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
