using System;
namespace Pets
{
    class pets
    {
        static void Main()
        {
            int daysAway = int.Parse(Console.ReadLine());
            int leavesFood = int.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine());
            double dogFood = daysAway * dog;
            double catFood = daysAway * cat;
            double turtleFood = (turtle / 1000) * daysAway;
            double sumFood = Math.Ceiling(dogFood + catFood + turtleFood);
            double difference = leavesFood - sumFood;
            if (difference >= 0)
            {
                Console.WriteLine("{0} kilos of food left.", difference);
            }
            if (difference < 0)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Abs(difference));
            }
        }
    }
}
