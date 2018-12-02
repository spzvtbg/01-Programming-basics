using System;
namespace Sequence2kPlus1
{
    class sequence2kPlus1
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 1;
            while (sum <= num)
            {
                Console.WriteLine(sum);
                sum *= 2;
                sum++;
            }
        }
    }
}
