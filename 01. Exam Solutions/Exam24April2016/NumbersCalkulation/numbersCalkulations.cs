using System;
namespace NumbersCalkulation
{
    class numbersCalkulations
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            double result = 0;

            if (sign == "+")
            {
                result = num1 + num2;
                string status = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{num1} + {num2} = {result} - {status}");
            }
            if (sign == "-")
            {
                result = num1 - num2;
                string status = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{num1} - {num2} = {result} - {status}");
            }
            if (sign == "*")
            {
                result = num1 * num2;
                string status = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{num1} * {num2} = {result} - {status}");
            }
            if (sign == "/")
            {
                if (num2 == 0)// || num1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
            }
            if (sign == "%")
            {
                if (num2 == 0)// || num1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
        }
    }
}
