using System;
namespace Prime
{
    class prime
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
            bool prime = true;
            if (n == 0 || n == 1 || n < 0)
            {
                Console.WriteLine("Not Prime");
            }
            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            if (prime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
