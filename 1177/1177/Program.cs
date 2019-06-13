using System;

namespace _1177
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[1000];
            int j = 0;
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = j;
                j++;
                if(j == T)
                {
                    j = 0;
                }

                Console.WriteLine($"N[{i}] = {vet[i]}");
            }
        }
    }
}
