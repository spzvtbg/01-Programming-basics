using System;
namespace Digits
{
    class digits
    {
        static void Main()
        {
            int input3DigitsNumber = int.Parse(Console.ReadLine());

            int digit3 = input3DigitsNumber % 10;
            int digit2 = (input3DigitsNumber / 10) % 10;
            int digit1 = input3DigitsNumber / 100;
            int rowsOfOutput = digit1 + digit2;
            int colonsOfOutput = digit1 + digit3;
            //Console.WriteLine("{0} {1} {2}", digit1, digit2, digit3);

            int newNumber = input3DigitsNumber;

            for (int a = 1; a <= rowsOfOutput; a++)
            {
                for (int b = 1; b <= colonsOfOutput; b++)
                {
                    if (newNumber % 5 == 0)
                    {
                        newNumber -= digit1;
                    }
                    else if (newNumber % 3 == 0)
                    {
                        newNumber -= digit2;
                    }
                    else
                    {
                        newNumber += digit3;
                    }
                    Console.Write(newNumber + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
