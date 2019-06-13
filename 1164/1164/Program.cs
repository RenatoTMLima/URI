using System;

namespace _1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int soma;

            for (int i = 0; i < n; i++)
            {
                soma = 0;
                int num = int.Parse(Console.ReadLine());

                for (int j = 1; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        soma += j;
                    }
                }
                if (soma == num)
                {
                    Console.WriteLine(num + " eh perfeito");
                }
                else
                {
                    Console.WriteLine(num + " nao eh perfeito");
                }
            }
        }
    }
}
