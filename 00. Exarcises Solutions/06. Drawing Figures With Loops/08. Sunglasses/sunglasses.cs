using System;
namespace Sunglasses
{
    class sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
            for (int a = 1; a <= n - 2; a++)
            {
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                if (a == ((n - 2) + 1) / 2)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.WriteLine("*");
            }
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
