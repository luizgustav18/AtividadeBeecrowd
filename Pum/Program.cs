using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        int contador = 1;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{contador} {contador + 1} {contador + 2} PUM");
            contador += 4;
        }
    }
}