﻿using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskFive
    {
        public static void Do()
        {
            int a,b;
            Console.Write("Please enter a: ");
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter b: ");
            while (true)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            double area = a * b / 2;
            double perimeter = a + b + Math.Sqrt(a * a + b * b);
            Console.WriteLine("Area: " + area + "; Perimeter: " + perimeter);
        }
    }
}
