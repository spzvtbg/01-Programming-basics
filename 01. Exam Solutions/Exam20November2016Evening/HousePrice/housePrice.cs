using System;
namespace HousePrice
{
    class housePrice
    {
        static void Main()
        {
            double litelRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double priceOfm2 = double.Parse(Console.ReadLine());
            double batroom = litelRoom / 2;
            double midleroom = litelRoom + litelRoom * 0.1;
            double largeRoom = midleroom + midleroom * 0.1;
            double floor = (litelRoom + midleroom + largeRoom + kitchen + batroom) * 0.05;
            double allm2 = litelRoom + midleroom + largeRoom + kitchen + batroom + floor;
            double price = allm2 * priceOfm2;
            Console.WriteLine("{0:f2}", price);
        }
    }
}
