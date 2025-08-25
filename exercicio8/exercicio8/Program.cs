using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; 
            double b;
            b = 1;
            Console.Write("Digite um número:");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(b);
                b = b * i;
                

         
            }
            Console.WriteLine(b);
        }
    }
}
