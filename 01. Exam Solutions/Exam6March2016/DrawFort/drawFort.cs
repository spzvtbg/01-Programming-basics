using System;
namespace DrawFort
{
    class drawFort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int MidleDashes = ((n - 1) / 2) * 2 - 2;
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.Write(new string('_', MidleDashes));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', n / 2 + 1));
                if (i == n - 2)
                {
                    Console.Write(new string('_', MidleDashes));
                }
                else
                {
                    Console.Write(new string(' ', MidleDashes));
                }
                Console.Write(new string(' ', n / 2 + 1));
                Console.WriteLine("|");
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', MidleDashes));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
