using System;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] vet;
            double a, b, c;

            for (int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                a = double.Parse(vet[0]);
                b = double.Parse(vet[1]);
                c = double.Parse(vet[2]);

                Console.WriteLine(((a*2+b*3+c*5)/10).ToString("F1"));
            }
        }
    }
}
