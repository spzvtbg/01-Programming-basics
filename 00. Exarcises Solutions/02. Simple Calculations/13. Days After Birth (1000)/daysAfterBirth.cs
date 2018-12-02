using System;
using System.Globalization;
namespace DaysAfterBirth_1000_
{
    class daysAfterBirth
    {
        static void Main()
        {
            string nowDate = Console.ReadLine();
            DateTime toDate = DateTime.ParseExact(nowDate, "dd-MM-yyyy", CultureInfo.InvariantCulture).AddDays(999);
            Console.WriteLine(toDate.ToString("dd-MM-yyyy"));
        }
    }
}
