namespace _02.Excellent_or_Not
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double result = double.Parse(Console.ReadLine());
            if (result >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else if (result < 5.5)
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
