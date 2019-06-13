using System;

namespace _1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    vet[i] = 1;
                }
                else{
                    vet[i] = n;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"X[{i}] = {vet[i]}");
            }
        }
    }
}
