using System;
namespace PowersOfTwo
{
    class powersOfTwo
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(n);
                n *= 2;
            }
        }
    }
}
