using System;
namespace LettersCombinations
{
    class lettersCombinations
    {
        static void Main()
        {
            int a = char.Parse(Console.ReadLine().ToLower());
            int b = char.Parse(Console.ReadLine().ToLower());
            int c = char.Parse(Console.ReadLine().ToLower());
            int min = a;
            int max = b;
            int count = 0;
            if (b < a)
            {
                min = b;
                max = a;
            }
            for (int i = min; i <= max; i++)
            {
                if (i == c)
                {
                    continue;
                }
                for (int j = min; j <= max; j++)
                {
                    if (j == c)
                    {
                        continue;
                    }
                    for (int l = min; l <= max; l++)
                    {
                        if (l == c)
                        {
                            continue;
                        }
                        count++;
                        Console.Write("{0}{1}{2} ", (char)(i), (char)(j), (char)(l));
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
