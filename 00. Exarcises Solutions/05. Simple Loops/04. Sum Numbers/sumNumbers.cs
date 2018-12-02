using System;
namespace SumNumbers
{
    class sumNumbers
    {
        static void Main()
        {
            //Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the numbers...");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                sum = sum + m;
            }
            //Console.WriteLine("sum = {0}", sum);
            Console.WriteLine(sum);
        }
    }
}
