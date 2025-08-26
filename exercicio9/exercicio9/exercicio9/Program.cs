using System;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            a = 0;
            b = 0;
            c = 0;
            d = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    a = a + 1;
                    Console.WriteLine($"{i}, este numero é par");
                }

                else
                {
                    b = b + 1;
                    Console.WriteLine($"{i}, este numero é impar");
                }

                if (i >= 0)
                {
                    c = c + 1;
                    Console.WriteLine($"{i}, este numero é positivo");
                }

                else
                {
                    d = d + 1;
                    Console.WriteLine($"{i}, este numero é negativo");
                }
            }
                Console.WriteLine($"Total de numeros pares: {a}");
                Console.WriteLine($"Total de numeros impares: {b}");
                Console.WriteLine($"Total de numeros positivos: {c}");
                Console.WriteLine($"Total de numeros negativos: {d}");
                do
                {
                    Console.WriteLine("\nDeseja encerrar o programa?");
                    Console.WriteLine("1. não");
                    Console.WriteLine("2. sim");

                    Console.Write("Escolha uma opção:\n");
                    e = int.Parse(Console.ReadLine());

                    switch (e)
                    {
                        case 1:
                            Console.WriteLine("progama não encerrado");

                            break;


                        case 2:
                        Console.WriteLine("encerrando o programa...");

                        break;



                        default:
                            Console.WriteLine("Opção Invalida");
                            break;
                    }
                } while (e <= 2);
            
        }
    }
}