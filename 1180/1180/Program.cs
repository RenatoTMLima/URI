using System;

namespace _1180
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            int[] vet2 = new int[N];
            int num = int.Parse(vet[0]), pos = 0;
            for (int i = 0; i < N; i++)
            {
                vet2[i] = int.Parse(vet[i]);
                if (num > vet2[i])
                {
                    num = vet2[i];
                    pos = i;
                }
            }
            Console.WriteLine("Menor valor: " + num);
            Console.WriteLine("Posicao: " + pos);
        }
    }
}
