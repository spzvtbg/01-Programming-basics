using System;
namespace Fox
{
    class fox
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int widht = num * 2 + 3;
            int dashes = widht - 4;
            int mid = num / 3;
            int stars = num / 2;
            int n = num;
            int dashes1 = widht - 4;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(new string('*', i) +
                    "\\" + new string('-', dashes) + "/" +
                    new string('*', i));
                dashes -= 2;
            }
            for (int i = 1; i <= mid; i++)
            {
                Console.WriteLine("|" + new string('*', stars) +
                                  "\\" + new string('*', n) + "/" +
                                    new string('*', stars) + "|");
                stars++;
                n -= 2;
            }
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(new string('-', i) +
                    "\\" + new string('*', dashes1) + "/" +
                    new string('-', i));
                dashes1 -= 2;
            }
        }
    }
}
