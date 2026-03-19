using System;

class Program
{
    static void Main()
    {
        int maior = int.MinValue;
        int posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor > maior)
            {
                maior = valor;
                posicao = i;
            }
        }

        Console.WriteLine("O maior numero escrito: " + maior);
        Console.WriteLine("Sua posição: " + posicao);
    }
}