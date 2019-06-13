using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];
            int[] vet2 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                vet2[19 - i] = vet[i];
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"N[{i}] = {vet2[i]}");
            }
        }
    }
}
