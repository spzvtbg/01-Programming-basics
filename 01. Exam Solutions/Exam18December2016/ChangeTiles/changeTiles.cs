using System;
namespace ChangeTiles
{
    class changeTiles
    {
        static void Main()
        {
            double SpendMoney = Double.Parse(Console.ReadLine());
            double FloorWidht = Double.Parse(Console.ReadLine());
            double FloorLenght = Double.Parse(Console.ReadLine());
            double PlateSide = Double.Parse(Console.ReadLine());
            double PlateHight = Double.Parse(Console.ReadLine());
            double PlatePrice = Double.Parse(Console.ReadLine());
            double PriceForWork = Double.Parse(Console.ReadLine());
            double FaceOfFloor = FloorLenght * FloorWidht;
            double FaceOfPlate = (PlateSide * PlateHight) / 2.00;
            double NeedPlates = Math.Ceiling(FaceOfFloor / FaceOfPlate) + 5;
            double TotalPricePlats = NeedPlates * PlatePrice;
            double TotalPrice = TotalPricePlats + PriceForWork;
            double Difference = Math.Abs(SpendMoney - TotalPrice);
            if (SpendMoney >= TotalPrice)
            {
                Console.WriteLine("{0:f2} lv left.", Difference);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", Difference);
            }
        }
    }
}
