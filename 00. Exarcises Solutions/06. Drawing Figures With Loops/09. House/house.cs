using System;
namespace House
{
    class house
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int RufsRow = ((n + 1) / 2) - 1;
            int TopStars = 2 - n % 2;
            int TopDashes = (n - TopStars) / 2;
            Console.Write(new string('-', TopDashes));
            Console.Write(new string('*', TopStars));
            Console.WriteLine(new string('-', TopDashes));
            for (int i = 1; i <= RufsRow; i++)
            {
                Console.Write(new string('-', TopDashes - i));
                Console.Write(new string('*', TopStars + i * 2));
                Console.WriteLine(new string('-', TopDashes - i));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
