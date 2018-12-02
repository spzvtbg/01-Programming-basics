using System;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string AreaOf = Console.ReadLine();

            if (AreaOf == "square")
            {
                double a = double.Parse(Console.ReadLine());

                double Area = a * a;

                Console.WriteLine(Area);
            }
            if (AreaOf == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double Area = a * b;

                Console.WriteLine(Area);
            }
            if (AreaOf == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double Area = Math.PI * r * r;

                Console.WriteLine("{0:0.000 }", Area);
            }
            if (AreaOf == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double Area = (c * h) / 2;

                Console.WriteLine(Area);

            }
        }
    }
}
