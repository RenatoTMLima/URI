using System;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            while(a != b)
            {
                if (a < b)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
            }
        }
    }
}
