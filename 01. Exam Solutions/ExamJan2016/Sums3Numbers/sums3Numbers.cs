using System;
namespace Sums3Numbers
{
    class sums3Numbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] array = new int[] { a, b, c };
            int min = 0;
            int mid = 0;
            int max = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                min = array[0];
                mid = array[1];
                max = array[2];
            }
            if (a + b == c || b + c == a || a + c == b)
            {
                Console.WriteLine("{0} + {1} = {2}", min, mid, max);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
