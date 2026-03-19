using System; 
class Program
{
    static void Main()
    {
        Console.Write("digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= N; i++)
        {
           fatorial *= i ;

        }
        Console.WriteLine("Sua fatorial: " + fatorial);
    }
}