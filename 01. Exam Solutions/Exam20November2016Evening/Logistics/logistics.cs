using System;
namespace Logistics
{
    class logistics
    {
        static void Main()
        {
            int loadNum = int.Parse(Console.ReadLine());
            int[] load = new int[loadNum];
            double loadSum = 0;
            int loadBusSum = 0;
            int loadTruckSum = 0;
            int loadTrainSum = 0;
            for (int i = 0; i <= load.Length - 1; i++)
            {
                load[i] = int.Parse(Console.ReadLine());
                if (load[i] <= 3)
                {
                    loadBusSum += load[i];
                }
                if (load[i] >= 4 && load[i] <= 11)
                {
                    loadTruckSum += load[i];
                }
                if (load[i] >= 12)
                {
                    loadTrainSum += load[i];
                }
                loadSum += load[i];
            }
            double averagePrice = (loadBusSum * 200 + loadTruckSum * 175 + loadTrainSum * 120) / loadSum;
            double BusProcent = (loadBusSum / loadSum) * 100;
            double TruckProcent = (loadTruckSum / loadSum) * 100;
            double TrainProcent = (loadTrainSum / loadSum) * 100;
            Console.WriteLine("{0:f2}", averagePrice);
            Console.WriteLine("{0:f2}%", BusProcent);
            Console.WriteLine("{0:f2}%", TruckProcent);
            Console.WriteLine("{0:f2}%", TrainProcent);
        }
    }
}
