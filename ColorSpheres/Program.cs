﻿using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Console.WriteLine($"Red Color: R={redColor.GetRed()}, G={redColor.GetGreen()}, B={redColor.GetBlue()}, A={redColor.GetAlpha()}");

            Sphere redSphere = new Sphere(redColor, 7.0f);

            redSphere.Throw();
            redSphere.Throw();
            redSphere.Throw();
            redSphere.Throw();
            redSphere.Throw();
            Console.WriteLine($"Sphere thrown {redSphere.GetTimesThrown()} times.");

            redSphere.Pop();
            Console.WriteLine($"Radius is {redSphere.GetRaio()}.");
        }
    }
}