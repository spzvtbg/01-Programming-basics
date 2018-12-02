using System;
namespace OddEvenSum
{
    class oddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int OddSum = 0;
            int EvenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += num;
                }
                else
                {
                    OddSum += num;
                }
            }
            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes\nSum = {0}", EvenSum);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(EvenSum - OddSum));
            }
        }
    }
}
