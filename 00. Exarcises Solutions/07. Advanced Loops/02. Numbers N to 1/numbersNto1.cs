using System;
namespace NumbersNto1
{
    class numbersNto1
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
