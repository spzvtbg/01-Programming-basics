﻿using System;
namespace CircleAreaAndPerimeter
{
    class circleAreaAndPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("Area = {0}\nPerimeter = {1}", area, perimeter);
        }
    }
}
