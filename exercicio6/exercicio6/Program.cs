using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            b = 0;
           
            for (int i = 1; i <= 10; i++)
            {


                Console.Write($"digite sua {i}º nota:");
                a = int.Parse(Console.ReadLine());

                if (a >= 0 && a <= 10)
                {
                    b = a + b;
                }

                else
                {
                    Console.WriteLine("numero invalido");
                }
            }
                  int c = b / 10;
                 Console.WriteLine($"A media das suas notas é: {c}");
             
        }
    }
}
