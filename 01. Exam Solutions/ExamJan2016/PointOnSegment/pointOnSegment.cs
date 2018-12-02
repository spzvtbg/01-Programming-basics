using System;
namespace PointOnSegment
{
    class pointOnSegment
    {
        static void Main()
        {
            int FirstPoint = int.Parse(Console.ReadLine());
            int SecondPoint = int.Parse(Console.ReadLine());
            int InputPoint = int.Parse(Console.ReadLine());
            int Difference = 0;
            int First1 = 0;
            int Second1 = 0;
            if (FirstPoint > SecondPoint)
            {
                First1 = SecondPoint;
                Second1 = FirstPoint;
            }
            else
            {
                First1 = FirstPoint;
                Second1 = SecondPoint;
            }
            if (InputPoint >= First1 && InputPoint <= Second1)
            {
                if (InputPoint - First1 < Second1 - InputPoint)
                {
                    Difference = InputPoint - First1;
                }
                else
                {
                    Difference = Second1 - InputPoint;
                }
                Console.WriteLine("in\n{0}", Math.Abs(Difference));
            }
            else if (InputPoint < First1)
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Abs(First1 - InputPoint));
            }
            else if (InputPoint > Second1)
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Abs(Second1 - InputPoint));
            }
        }
    }
}
