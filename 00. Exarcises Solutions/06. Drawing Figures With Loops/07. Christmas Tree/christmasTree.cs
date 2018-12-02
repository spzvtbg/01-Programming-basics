using System;
namespace ChristmasTree
{
    class christmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n;
            int stars = 0;
            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string(' ', spaces - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                Console.WriteLine(new string(' ', spaces - row));
            }
        }
    }
}
