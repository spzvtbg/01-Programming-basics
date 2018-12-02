using System;
namespace InvalidNumber
{
    class invalidNumber
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            if (num >= 100 && num <= 200 || num == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
