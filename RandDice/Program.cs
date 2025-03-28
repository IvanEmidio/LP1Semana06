using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            Random random= new Random(s);

            int total = 0;


            for(int i = 0; i < n; i++)
            {
                total += random.Next(1,7);
            }

            Console.WriteLine(total);
        }
    }
}
