using System;
namespace Cinema
{
    class cinema
    {
        static void Main()
        {
            string kind = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double tickets = 0;
            if (kind != "Premiere" && kind != "Normal" && kind != "Discount")
            {
                Console.WriteLine("error");
            }
            if (kind == "Premiere")
            {
                tickets = 12.00;
                double sum = row * col * tickets;
                Console.WriteLine("{0:f2} leva", sum);
            }
            if (kind == "Normal")
            {
                tickets = 7.50;
                double sum = row * col * tickets;
                Console.WriteLine("{0:f2} leva", sum);
            }
            if (kind == "Discount")
            {
                tickets = 5.00;
                double sum = row * col * tickets;
                Console.WriteLine("{0:f2} leva", sum);
            }
        }
    }
}
