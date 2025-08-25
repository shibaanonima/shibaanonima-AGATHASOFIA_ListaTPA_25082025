using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"{i} É MÚLTIPLO DE 10");
                }
                else
                    Console.WriteLine(i); 
                }

        }
    }
}
