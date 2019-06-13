using System;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n;
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            n = int.Parse(vet[vet.Length-1]);

            int soma = 0;

            while (n<1)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (int i = a; i < a+n; i++)
            {
                soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
