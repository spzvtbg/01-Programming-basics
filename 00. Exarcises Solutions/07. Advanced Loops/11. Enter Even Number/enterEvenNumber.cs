﻿using System;
namespace EnterEvenNumber
{
    class enterEvenNumber
    {
        static void Main()
        {
            int n;
            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (true);
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
