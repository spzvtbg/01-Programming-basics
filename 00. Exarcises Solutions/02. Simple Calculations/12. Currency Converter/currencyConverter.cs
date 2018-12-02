using System;namespace CurrencyConverter
{
    class currencyConverter
    {
        static void Main()
        {
            //BGN, USD, EUR, GBP.
            double money = double.Parse(Console.ReadLine());
            string fromCurrency = Console.ReadLine();
            string toCurrency = Console.ReadLine();

            double BGN = 1;
            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;

            double fromCurr = 0;
            double toCurr = 0;

            switch (fromCurrency)
            {
                case "BGN": fromCurr = 1; break;
                case "USD": fromCurr = 1.79549; break;
                case "EUR": fromCurr = 1.95583; break;
                case "GBP": fromCurr = 2.53405; break;
            }
            switch (toCurrency)
            {
                case "BGN": toCurr = fromCurr / BGN; break;
                case "USD": toCurr = fromCurr / USD; break;
                case "EUR": toCurr = fromCurr / EUR; break;
                case "GBP": toCurr = fromCurr / GBP; break;
            }

            double result = money * toCurr;
            Console.WriteLine($"{Math.Round(result, 2)} {toCurrency}");
        }
    }
}
