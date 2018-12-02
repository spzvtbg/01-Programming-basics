using System;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int sec = time1 + time2 + time3;
            int autputmin = sec / 60;
            int autputsec = sec % 60;

            if (autputsec < 10)
            {
                Console.WriteLine("{0}:0{1}", autputmin, autputsec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", autputmin, autputsec);
            }
        }
    }
}
