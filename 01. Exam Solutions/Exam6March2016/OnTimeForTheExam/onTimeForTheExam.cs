using System;
using System.Globalization;
namespace OnTimeForTheExam
{
    class onTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minOfExam = int.Parse(Console.ReadLine());
            int hourToArrivel = int.Parse(Console.ReadLine());
            int minToArrivel = int.Parse(Console.ReadLine());
            int exam = hourOfExam * 60 + minOfExam;
            int arrivel = hourToArrivel * 60 + minToArrivel;
            int span = exam - arrivel;
            int H = span / 60;
            int mm = span % 60;
            string diff = "0:00";
            if (span > 30)
            {
                Console.WriteLine("Early");
                if (span > 30 && span > 59)
                {
                    DateTime result = DateTime.ParseExact(diff, "H:mm",
                    CultureInfo.InvariantCulture).AddMinutes(Math.Abs(span));
                    Console.WriteLine(result.ToString("H:mm") + " hours before the start");
                }
                else if (span > 30 && span <= 59)
                {
                    DateTime result = DateTime.ParseExact(diff, "H:mm",
                                        CultureInfo.InvariantCulture).AddMinutes(Math.Abs(span));
                    Console.WriteLine(result.ToString("mm") + " minutes before the start");
                }
            }
            else if (span <= 30 && span >= 0)
            {
                if (span == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (span <= 30)
                {
                    Console.WriteLine("On time");
                    DateTime result = DateTime.ParseExact(diff, "H:mm",
                                                            CultureInfo.InvariantCulture).AddMinutes(Math.Abs(span));
                    Console.WriteLine(span + " minutes before the start");
                }
            }
            else if (span < 0)
            {
                if (span >= -59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine(Math.Abs(span) + " minutes after the start");
                }
                else if (span <= -59)
                {
                    DateTime result = DateTime.ParseExact(diff, "H:mm",
                                                 CultureInfo.InvariantCulture).AddMinutes(Math.Abs(span));
                    Console.WriteLine("Late");
                    Console.WriteLine(result.ToString("H:mm") + " hours after the start");
                }
            }
        }
    }
}
