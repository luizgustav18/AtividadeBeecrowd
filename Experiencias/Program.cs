using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de experimentos: ");
        int N = int.Parse(Console.ReadLine());

        int total = 0;
        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"\nExperimento {i}:");

            int quantia;

            // 🔁 garante que esteja entre 1 e 15
            do
            {
                Console.Write("Quantidade de cobaias (1 a 15): ");
                quantia = int.Parse(Console.ReadLine());

                if (quantia < 1 || quantia > 15)
                    Console.WriteLine("Valor inválido! Digite entre 1 e 15.");
            }
            while (quantia < 1 || quantia > 15);

            Console.Write("Tipo (C = coelho, R = rato, S = sapo): ");
            char tipo = char.Parse(Console.ReadLine().ToUpper());

            total += quantia;

            if (tipo == 'C')
                coelhos += quantia;
            else if (tipo == 'R')
                ratos += quantia;
            else if (tipo == 'S')
                sapos += quantia;
        }

        double percCoelhos = (double)coelhos / total * 100;
        double percRatos = (double)ratos / total * 100;
        double percSapos = (double)sapos / total * 100;

        Console.WriteLine("\nRESULTADO:");
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);

        Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2") + " %");
    }
}