using System;
namespace Fibonacci
{
    class fibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int Num = 1;// 1 1 (1 + 1)2 (2 + 1)3 (3 + 2)5 (5 + 3)8 (8 + 5...)13 21 34 55 ...
            int Sum = 1;
            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    int fibonachiNum = Sum + Num;
                    Num = Sum;
                    Sum = fibonachiNum;
                }
                Console.WriteLine(Sum);
            }
        }
    }
}
