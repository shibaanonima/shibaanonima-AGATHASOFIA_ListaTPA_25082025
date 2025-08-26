using System;

class Program
{
    static void Main(string[] args)
    {
        string resposta;

        do
        {
            
            Console.Write("Digite o código do operário: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            int N = int.Parse(Console.ReadLine());

            
            int salarioBase = 10 * N;
            int E = 0; 

            if (N > 50)
            {
                int horasExcedentes = N - 50;
                E = horasExcedentes * 20;
            }

            int salarioTotal = salarioBase + E;

           
            Console.WriteLine("\n Resultado ");
            Console.WriteLine($"Código do operário: {C}");
            Console.WriteLine($"Salário excedente: R$ {E}");
            Console.WriteLine($"Salário total: R$ {salarioTotal}\n");

          
            Console.Write("Deseja encerrar o programa? (S/N): ");
            resposta = Console.ReadLine().ToUpper();

            switch (resposta)
            {
                case "S":
                    Console.WriteLine("Programa encerrado!");
                    break;
                case "N":
                    Console.WriteLine("O programa continuará...\n");
                    break;
                default:
                    Console.WriteLine("Opção inválida, o programa continuará...\n");
                    resposta = "N";
                    break;
            }

        } while (resposta != "S"); 
    }
}

