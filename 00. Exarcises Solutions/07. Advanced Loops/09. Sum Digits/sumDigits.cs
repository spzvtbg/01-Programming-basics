using System;
namespace SumDigits
{
    class sumDigits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            while (n > 0)
            {
                int rem = n % 10;
                result += rem;
                n = n / 10;
            }
            Console.WriteLine(result);
        }
    }
}
