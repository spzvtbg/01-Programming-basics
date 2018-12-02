using System;
namespace Match_Tickets
{
    class matchTickets
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            double numOfPeople = byte.Parse(Console.ReadLine());

            double transport = 0;
            double ticketsSum = 0;

            switch (category)
            {
                case "vip": ticketsSum = numOfPeople * 499.99; break;
                case "normal": ticketsSum = numOfPeople * 249.99; break;
                default:
                    break;
            }
            if (numOfPeople <= 4)
            {
                transport = budget * 0.75;
            }
            if (numOfPeople > 4 && numOfPeople <= 9)
            {
                transport = budget * 0.60;
            }
            if (numOfPeople > 9 && numOfPeople <= 24)
            {
                transport = budget * 0.50;
            }
            if (numOfPeople > 24 && numOfPeople <= 49)
            {
                transport = budget * 0.40;
            }
            if (numOfPeople >= 50)
            {
                transport = budget * 0.25;
            }

            double restMoney = budget - transport;
            double moneyDiff = restMoney - ticketsSum;

            if (moneyDiff >= 0)
            {
                Console.WriteLine("Yes! You have {0:0.00} leva left.", moneyDiff);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:0.00} leva.", Math.Abs(moneyDiff));
            }
        }
    }
}
