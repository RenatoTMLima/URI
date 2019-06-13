using System;

namespace _1178
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] N = new double[100];
            N[0] = double.Parse(Console.ReadLine());

            Console.WriteLine($"N[0] = {N[0].ToString("F4")}");
            for (int i = 1; i < 100; i++)
            {
                N[i] = N[i - 1] / 2;
                Console.WriteLine($"N[{i}] = {N[i].ToString("F4")}");
            }

        }
    }
}
