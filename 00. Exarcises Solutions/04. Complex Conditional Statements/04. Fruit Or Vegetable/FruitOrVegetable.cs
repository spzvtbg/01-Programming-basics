using System;
namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string p = Console.ReadLine().ToLower();
            if (p == "banana" || p == "apple" || p == "kiwi" || p == "cherry" || p == "lemon" || p == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (p == "tomato" || p == "cucumber" || p == "pepper" || p == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
