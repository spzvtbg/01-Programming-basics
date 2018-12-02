using System;
namespace SumOfTwoNumbers
{
    class sumOfTwoNumbers
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int theNumber = int.Parse(Console.ReadLine());

            int ctr = 0;
            int result = 0;
            int a1 = 0;
            int b1 = 0;

            for (int a = start; a <= end; a++)
            {
                a1 = a;
                for (int b = start; b <= end; b++)
                {
                    b1 = b;
                    ctr++;
                    result = a1 + b1;
                    if (result == theNumber)
                    {
                        break;
                    }
                }
                if (result == theNumber)
                {
                    break;
                }
            }
            if (result == theNumber)
            {
                Console.WriteLine($"Combination N:{ctr} ({a1} + {b1} = {theNumber})");
            }
            else
            {
                Console.WriteLine($"{ctr} combinations - neither equals {theNumber}");
            }
        }
    }
}
