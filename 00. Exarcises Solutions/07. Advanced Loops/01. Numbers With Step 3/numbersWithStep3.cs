using System;
namespace NumbersWithStep3
{
    class numbersWithStep3
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
