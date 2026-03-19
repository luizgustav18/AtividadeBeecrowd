using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos números você vai digitar: ");
        int N = int.Parse(Console.ReadLine());

        int dentro = 0;
        int fora = 0;

        for (int i = 1; i <= N; i++)
        {
            Console.Write("Digite um número: ");
            int X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }

        Console.WriteLine(dentro + " estão");
        Console.WriteLine(fora + " Não estão");
    }
}