using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int X = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um valor: ");
        int Y = int.Parse(Console.ReadLine());

        int inicio = Math.Min(X, Y);
        int fim = Math.Max(X, Y);

        int soma = 0;

        for (int i = inicio; i <= fim; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("Sua soma é: " + soma);
    }
}