using System;
namespace FruitShop
{
    class fruitShop
    {
        static void Main()
        {
            string fruits = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" ||
                dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                switch (fruits)
                {
                    case "banana": price = 2.50 * quantity; break;
                    case "apple": price = 1.20 * quantity; break;
                    case "orange": price = 0.85 * quantity; break;
                    case "grapefruit": price = 1.45 * quantity; break;
                    case "kiwi": price = 2.70 * quantity; break;
                    case "pineapple": price = 5.50 * quantity; break;
                    case "grapes": price = 3.85 * quantity; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                switch (fruits)
                {
                    case "banana": price = 2.70 * quantity; break;
                    case "apple": price = 1.25 * quantity; break;
                    case "orange": price = 0.90 * quantity; break;
                    case "grapefruit": price = 1.60 * quantity; break;
                    case "kiwi": price = 3.00 * quantity; break;
                    case "pineapple": price = 5.60 * quantity; break;
                    case "grapes": price = 4.20 * quantity; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"{Math.Round(price, 2)}");
        }
    }
}
