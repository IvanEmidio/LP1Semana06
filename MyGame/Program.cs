using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);

            Enemy[] enemies = new Enemy[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nome do inimigo {i + 1}");
            }
            
        }
    }
}
