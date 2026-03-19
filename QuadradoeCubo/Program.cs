using System;

class Program
{
    static void Main()

    {
        Console.WriteLine("Digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            double quadrado = Math.Pow (i,2);
            double cubo = Math.Pow (i, 3);

            Console.WriteLine(i + " " + quadrado + " " + cubo);
        }
    }
}