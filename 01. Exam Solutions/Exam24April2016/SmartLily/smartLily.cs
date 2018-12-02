using System;
namespace SmartLily
{
    class smartLily
    {
        static void Main()
        {
            int lilisOld = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toyConter = 0;
            int count = 0;
            int evenBirthDays = 0;
            int moneySum = 0;
            for (int a = 1; a <= lilisOld; a++)
            {
                if (a % 2 != 0)
                {
                    toyConter++;
                }
                else
                {
                    count++;
                    evenBirthDays += 10;
                    moneySum += evenBirthDays;
                }
            }
            toyPrice *= toyConter;
            double allMoney = toyPrice + moneySum - count;
            double moneyDiff = allMoney - laundryPrice;
            if (moneyDiff >= 0)
            {
                Console.WriteLine($"Yes! {moneyDiff:0.00}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(moneyDiff):0.00}");
            }
        }
    }
}
