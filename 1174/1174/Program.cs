using System;

namespace _1174
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[100];

            for (int i = 0; i < 100; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 100; i++)
            {
                if (vet[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {vet[i].ToString("F1")}");
                }
            }
        }
    }
}
