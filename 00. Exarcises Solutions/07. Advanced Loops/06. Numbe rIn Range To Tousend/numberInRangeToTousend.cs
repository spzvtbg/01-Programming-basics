﻿using System;
namespace NumberInRangeToTousend
{
    class numberInRangeToTousend
    {
        static void Main()
        {
            Console.Write("Enter a number in range [1 ... 100]: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("invalid number!");
                Console.Write("Enter a number in range [1 ... 100]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
