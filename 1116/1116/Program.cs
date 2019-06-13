using System;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, y;
            double div =0;
            string[] vet;

            for (int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if(y != 0)
                {
                    div = (double) x / y;
                    Console.WriteLine(div.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
