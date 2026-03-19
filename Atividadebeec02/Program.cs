using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Digite outro valor: ");
        int Y = int.Parse(Console.ReadLine());

        int soma = 0;

        int menor = Math.Min(X, Y);
        int maior = Math.Max(X, Y);

        for (int i = menor + 1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("A soma dos valores: " + soma);
    }
}