using System;
namespace Diamond
{
    class diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int UpDownStars = 2 - n % 2;
            int TopRows = (n + 1) / 2;
            int LowRows = n - TopRows;
            int dashes = (n - UpDownStars) / 2;
            if (n == 1)
            {
                Console.Write(new string('-', dashes));
                Console.Write(new string('*', UpDownStars));
                Console.WriteLine(new string('-', dashes));
            }
            if (n == 2)
            {
                Console.WriteLine("**");
            }
            if (n > 2)
            {
                Console.Write(new string('-', dashes));
                Console.Write(new string('*', UpDownStars));
                Console.WriteLine(new string('-', dashes));
                for (int a = 0; a < TopRows - 1; a++)
                {
                    int InSideDashes = UpDownStars + a * 2;
                    int OutSideDashes = Math.Abs(n - InSideDashes - 2) / 2;
                    Console.Write(new string('-', OutSideDashes));
                    Console.Write("*");
                    Console.Write(new string('-', InSideDashes));
                    Console.Write("*");
                    Console.WriteLine(new string('-', OutSideDashes));
                }

                for (int b = 0; b < TopRows - 2; b++)
                {
                    int OutSideDashes = b + 1;
                    int InSideDashes = n - 2 - OutSideDashes * 2;
                    Console.Write(new string('-', OutSideDashes));
                    Console.Write("*");
                    Console.Write(new string('-', InSideDashes));
                    Console.Write("*");
                    Console.WriteLine(new string('-', OutSideDashes));
                }

                Console.Write(new string('-', dashes));
                Console.Write(new string('*', UpDownStars));
                Console.WriteLine(new string('-', dashes));
            }
        }
    }
}
