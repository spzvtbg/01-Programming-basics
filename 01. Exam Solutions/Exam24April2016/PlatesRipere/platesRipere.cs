using System;
namespace PlatesRipere
{
    class platesRipere
    {
        static void Main()
        {
            // N – дължината на страна от площадката в интервала[1...100]
            double landingLenght = double.Parse(Console.ReadLine());
            // W – широчината на една плочка в интервала[0.1...10.00]
            double plateWidth = double.Parse(Console.ReadLine());
            // L – дължината на една плочка в интервала[0.1...10.00]
            double plateLenght = double.Parse(Console.ReadLine());
            // М – широчината на пейката в интервала[0...10]
            double benchWidth = double.Parse(Console.ReadLine());
            // О – дължината на пейката в интервала[0...10]
            double benchLenght = double.Parse(Console.ReadLine());

            double putOfPlate = 0.2;
            double plateArray = plateLenght * plateWidth;

            double landingFace = landingLenght * landingLenght;
            double benchFace = benchLenght * benchWidth;
            double leftArea = landingFace - benchFace;

            double neededPlates = leftArea / plateArray;
            double timeForWork = neededPlates * putOfPlate;

            Console.WriteLine(neededPlates);
            Console.WriteLine(timeForWork);
        }
    }
}
