using System;

namespace _16.Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] SimpleNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] TensNumbers = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };
            string[] OtherNumbers = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string nameOfTheNumber;
            int result1 = 0;
            int result2 = 0;
            if (num >= 0 && num <= 100)
            {
                if (num < 10)
                {
                    nameOfTheNumber = SimpleNumbers[num];
                    Console.WriteLine(nameOfTheNumber);
                }
                else if (num > 9 && num < 20)
                {
                    result1 = num % 10;
                    nameOfTheNumber = OtherNumbers[result1];
                    Console.WriteLine(nameOfTheNumber);
                }
                else if (num > 19 && num % 10 != 0)
                {
                    result1 = num / 10;
                    result2 = num % 10;
                    Console.WriteLine(TensNumbers[result1 - 1] + " " + SimpleNumbers[result2]);
                }
                else if (num % 10 == 0)
                {
                    result1 = num / 10;
                    Console.WriteLine(TensNumbers[result1 - 1]);
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
