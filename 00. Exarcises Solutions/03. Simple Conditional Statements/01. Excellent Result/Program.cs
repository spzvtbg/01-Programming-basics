namespace _01.Excellent_Result
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
        }
    }
}
