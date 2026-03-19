using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                Console.Write("EVEN ");
            }
            else
            {
                Console.Write("ODD ");
            }

            if (X > 0)
            {
                Console.WriteLine("POSITIVE");
            }
            else if(X ==0 )
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine("NEGATIVE");
            }
        }
    }
}