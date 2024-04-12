using System;

namespace ColorSpheres
{
    class Sphere
    {
        private readonly Color color;
        private float raio;
        private int throws;
        public Sphere(Color color, float raio)
        {
            this.color = color;
            this.raio = raio;
            throws = 0;
        }
        public void Pop()
        {
            raio = 0;
        }
        public void Throw()
        {
            throws++;
        }
        public int GetTimesThrown()
        {
            return throws;
        }
        public float GetRaio()
        {
            return raio;
        }
    }
}