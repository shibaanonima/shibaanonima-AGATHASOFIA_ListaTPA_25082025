using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("digite um numero:");
                a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a} x {i} = {a * i}");
            }
        
        }
    }
}
