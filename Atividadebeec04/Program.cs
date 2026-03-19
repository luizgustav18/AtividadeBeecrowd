using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor: ");
        int X = int.Parse(Console.ReadLine());

        for (int i = 1; i <= X; i++)
        {
            if (i % 2 == 0)
            {
                double quadrado = Math.Pow(i,2);
                Console.WriteLine("O quadrado do números pares " + i + " é: " + quadrado);
            }
        }
    }
}
