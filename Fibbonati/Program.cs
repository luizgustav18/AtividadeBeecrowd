using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        for (int i = 0; i < N; i++)
        {
            if (i == N - 1)
                Console.Write(a);
            else
                Console.Write(a + " ");

            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}