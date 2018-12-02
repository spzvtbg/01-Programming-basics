namespace _03.Even_or_Odd
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
