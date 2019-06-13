using System;

namespace _1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            vet[0] = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                vet[i] = vet[i - 1] * 2;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
