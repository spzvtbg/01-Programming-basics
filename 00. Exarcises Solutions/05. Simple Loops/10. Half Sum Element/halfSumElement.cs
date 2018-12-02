using System;
namespace HalfSumElement
{
    class halfSumElement
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int MaxValue = int.MinValue;
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers > MaxValue)
                {
                    MaxValue = numbers * 2;
                }
            }
            if (MaxValue == sum)
            {
                Console.WriteLine("Yes\nSum = {0}", sum / 2);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(MaxValue - sum));
            }
        }
    }
}
