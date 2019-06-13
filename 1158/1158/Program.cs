using System;

namespace _1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] vet;
            int y, x, j, soma;
            for (int i = 0; i < n; i++)
            {
                j = 0;
                soma = 0;
                vet = Console.ReadLine().Split(' ');
                y = int.Parse(vet[0]);
                x = int.Parse(vet[1]);

                while (j<x)
                {
                    if (y%2!=0)
                    {
                        soma += y;
                        y += 2;
                        j++;
                    }
                    else
                    {
                        y++;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
