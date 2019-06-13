using System;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a, b, soma = 0;
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            while(a>0 && b > 0)
            {
                if (a < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        Console.Write(i + " ");
                        soma += i;
                    }
                    Console.WriteLine("Sum=" + soma);
                }
                else
                {
                    for (int i = b; i <= a; i++)
                    {
                        Console.Write(i + " ");
                        soma += i;
                    }
                    Console.WriteLine("Sum=" + soma);
                }
                soma = 0;
                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
            }
        }
    }
}
