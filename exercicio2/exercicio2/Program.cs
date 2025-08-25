using System;

class Program
{
    static void Main()
    {
        int a, b;
        Console.Write("digite um numero menor:");
        a = int.Parse(Console.ReadLine());
        Console.Write("digite outro numero maior:");
        b = int.Parse(Console.ReadLine());
        if ( a > b)
        {
            Console.WriteLine("erro, você preencheu os campos de forma incorreta");
        }
        for (int i = b; i >= a; i--)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}

