using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color vermelho = new Color(255, 0, 0);

            Sphere esfera = new Sphere(vermelho, 5.0f);

            esfera.Throw();
            esfera.Throw();

            Console.WriteLine($"Sphere thrown {esfera.Throws} times.");

            esfera.Pop();
            esfera.Pop();
            esfera.Pop();
            esfera.Pop();

            Console.WriteLine($"Radius is {esfera.Raio}.");
        }
    }
}
