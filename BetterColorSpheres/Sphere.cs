using System;

namespace BetterColorSpheres
{
    class Sphere
    {
        private readonly Color color;
        public float Raio { get; set; }
        public int Throws { get; set; } = 0;
        public Sphere(Color color, float raio)
        {
            this.color = color;
            this.raio = raio;
        }
        public void Pop()
        {
            raio = 0;
        }
        public void Throw()
        {
            throws++;
        }
    }
}