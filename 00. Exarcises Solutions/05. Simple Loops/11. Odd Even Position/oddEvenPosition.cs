using System;
namespace OddEvenPosition
{
    class oddEvenPosition
    {
        static void Main()
        {
            int Num = int.Parse(Console.ReadLine());
            if (Num == 0)
            {
                Console.WriteLine("OddSum = 0\nOddMin = No\nOddMax = No\nEvenSum = 0\nEvenMin = No\nEvenMax = No");
            }
            double MaxEven = -1000000000.0;
            double MinEven = 1000000000.0;
            double MaxOdd = -1000000000.0;
            double MinOdd = 1000000000.0;
            double EvenSum = 0;
            double OddSum = 0;
            for (int i = 1; i <= Num; i++)
            {
                double Numbers = double.Parse(Console.ReadLine());
                if (Num == 1)
                {
                    Console.WriteLine("OddSum = {0}\nOddMin = {0}\nOddMax = {0}\nEvenSum = 0\nEvenMin = No\nEvenMax = No", Numbers);
                    break;
                }
                if (i % 2 > 0)
                {
                    OddSum = OddSum + Numbers;
                    if (Numbers < MinOdd)
                    {
                        MinOdd = Numbers;
                    }
                    if (MaxOdd < Numbers)
                    {
                        MaxOdd = Numbers;
                    }
                }
                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + Numbers;
                    if (Numbers < MinEven)
                    {
                        MinEven = Numbers;
                    }
                    if (MaxEven < Numbers)
                    {
                        MaxEven = Numbers;
                    }
                }
                Console.WriteLine("OddSum = {0}", OddSum);
                Console.WriteLine("OddMin = {0}", MinOdd);
                Console.WriteLine("OddMax = {0}", MaxOdd);
                Console.WriteLine("EvenSum = {0}", EvenSum);
                Console.WriteLine("EvenMin = {0}", MinEven);
                Console.WriteLine("EvenMax = {0}", MaxEven);
            }
        }
    }
}
