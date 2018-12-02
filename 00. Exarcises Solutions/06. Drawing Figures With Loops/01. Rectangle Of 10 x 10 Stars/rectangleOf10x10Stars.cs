using System;
namespace RectangleOf10x10Stars
{
    class rectangleOf10x10Stars
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                string a = new string('*', 10);
                Console.WriteLine(a);
            }
        }
    }
}
