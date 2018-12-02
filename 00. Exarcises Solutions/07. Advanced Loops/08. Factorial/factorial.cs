using System;
namespace Factorial
{
    class factorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            int counter = 1;
            do
            {
                result = result * counter;
                counter++;
            } while (counter <= n);
            Console.WriteLine(result);
        }
    }
}
