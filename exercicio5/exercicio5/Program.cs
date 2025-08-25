using System;

class Program
{
    static void Main()
    {
        int numero, maior;

        Console.Write("Digite o 1º número: ");
        numero = int.Parse(Console.ReadLine());

        maior = numero;

        for (int i = 2; i <= 15; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\nO maior número digitado foi: {maior}");
    }
}

