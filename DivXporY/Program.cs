using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Digite outro valor: ");
        int Y = int.Parse(Console.ReadLine());

        if (Y == 0)
        {
            Console.WriteLine("Não é possível dividir por zero!");
        }
        else
        {
            double div = (double)X / Y;
            Console.WriteLine("Sua divisão: " + div);
        }
    }
}