using System;
namespace FlowerShop
{
    class flowerShop
    {
        static void Main()
        {
            double magnolia = double.Parse(Console.ReadLine()) * 3.25;
            double hyacinths = double.Parse(Console.ReadLine()) * 4.00;
            double rose = double.Parse(Console.ReadLine()) * 3.50;
            double cactus = double.Parse(Console.ReadLine()) * 8.00;
            double giftPrice = double.Parse(Console.ReadLine());
            double tax = (magnolia + hyacinths + rose + cactus) * 0.05;
            double flowersSum = (magnolia + hyacinths + rose + cactus) - tax;
            double difference = flowersSum - giftPrice;
            if (difference >= 0)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Truncate(difference));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(Math.Abs(difference)));
            }
        }
    }
}
