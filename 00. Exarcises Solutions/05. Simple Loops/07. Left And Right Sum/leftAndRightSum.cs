using System;
namespace LeftAndRightSum
{
    class leftAndRightSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int SumLeft = 0;
            int SumRight = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                SumLeft += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                SumRight += num;
            }
            if (SumLeft == SumRight)
            {
                Console.WriteLine("Yes, sum = {0}", SumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(SumLeft - SumRight));
            }
        }
    }
}
