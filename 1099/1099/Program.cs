using System;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, b, soma;
            string[] vet;

            for (int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
                soma = 0;

                if(a < b)
                {
                    for (int j = a+1; j < b; j++)
                    {
                        if(j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                }
                else
                {
                    for (int j = b + 1; j < a; j++)
                    {
                        if (j % 2 != 0)
                        {
                            soma += j;
                        }
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
