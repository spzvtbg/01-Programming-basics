using System;
namespace EqualPairs
{
    class equalPairs
    {
        static void Main()
        {
            double NumCouples = int.Parse(Console.ReadLine());
            double FrontSum = 0;
            double MaxDiff = int.MinValue;
            double SumNumbers = 0;
            double AllSums = 0;
            double Diff = 0;
            double EndDiff = 0;
            for (double i = 1; i <= NumCouples; i++)
            {
                FrontSum = SumNumbers;
                double Number1 = double.Parse(Console.ReadLine());
                double Number2 = double.Parse(Console.ReadLine());
                SumNumbers = Number1 + Number2;
                AllSums += SumNumbers;
                MaxDiff = Math.Abs(FrontSum - SumNumbers);
            }
            if (SumNumbers == AllSums / NumCouples)
            {
                Console.WriteLine("Yes, value = {0}", SumNumbers);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", MaxDiff);
            }
        }
    }
}
