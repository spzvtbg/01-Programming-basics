using System;

namespace _04.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber1 = int.Parse(Console.ReadLine());
            int inputNumber2 = int.Parse(Console.ReadLine());

            if (inputNumber1 < inputNumber2)
            {
                Console.WriteLine(inputNumber2);
            }
            else
            {
                Console.WriteLine(inputNumber1);
            }
        }
    }
}
