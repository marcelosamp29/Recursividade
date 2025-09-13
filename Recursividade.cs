using System;

class Program
{
    static int SomaRecursiva(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return n + SomaRecursiva(n - 1); 
    }

    static void Main(string[] args)
    {
        int n = 0;

        while (true)
        {
            Console.Write("Digite um número positivo (0 para sair): ");
            n = int.Parse(Console.ReadLine());

            if (n == 0) 
            {
                break;
            }

            if (n < 0)
            {
                Console.WriteLine("Número inválido! Digite um valor positivo.");
                continue;
            }

            int resultado = SomaRecursiva(n);

            Console.WriteLine($"A soma de 1 até {n} é: {resultado}");
            Console.WriteLine();
        }
    }
}
