using System;
namespace MaxCombination
{
    class maxCombination
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxCom = int.Parse(Console.ReadLine());
            int min = num1;
            int max = num2;
            int count = 0;
            if (num2 < num1)
            {
                min = num2;
                max = num1;
            }
            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    if (count == maxCom)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
