using System;
namespace Distance
{
    class distance
    {
        static void Main()
        {
            double FirstSpeed = Double.Parse(Console.ReadLine());
            double TimeTo10 = Double.Parse(Console.ReadLine());
            double TimeLow5 = Double.Parse(Console.ReadLine());
            double EndTime = Double.Parse(Console.ReadLine());
            double SpeedTo10 = FirstSpeed + (FirstSpeed * 0.10);
            double SpeedLow5 = SpeedTo10 - (SpeedTo10 * 0.05);
            double KmTo10 = (TimeTo10 / 60) * FirstSpeed;
            double KmLow5 = (TimeLow5 / 60) * SpeedTo10;
            double KmToEnd = (EndTime / 60) * SpeedLow5;
            double TotalKm = KmTo10 + KmLow5 + KmToEnd;
            Console.WriteLine("{0:f2}", TotalKm);
        }
    }
}
