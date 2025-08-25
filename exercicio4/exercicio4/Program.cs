

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            c = 0;
            Console.Write("Digite um numero:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero:");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)

                    c = c + 1;
            }
            Console.WriteLine($" existem {c} numeros impares entre {a} e {b}");
            Console.ReadKey();
        }
    }
}
