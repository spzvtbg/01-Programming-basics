using System;
namespace RectangleOfNxNStars
{
    class rectangleOfNxNStars
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                string a = new string('*', N);
                Console.WriteLine(a);
            }
        }
    }
}
