using System;

namespace _1179
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] par = new int[5];
            int[] impar = new int[5];

            int i, p, res;
            i = p = 0;

            for (int j = 0; j < 15; j++)
            {
                res = int.Parse(Console.ReadLine());
                if (res % 2 == 0)
                {
                    par[p] = res;
                    p++;
                    if (p == 5)
                    {
                        for (int n = 0; n < 5; n++)
                        {
                            Console.WriteLine($"par[{n}] = " + par[n]);
                        }
                        p = 0;
                    }
                    
                }
                else
                {
                    impar[i] = res;
                    i++;
                    if (i == 5)
                    {
                        for (int n = 0; n < 5; n++)
                        {
                            Console.WriteLine($"impar[{n}] = " + impar[n]);
                        }
                        i = 0;
                    }
                    
                }
            }
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"impar[{j}] = " + impar[j]);
            }
            for (int j = 0; j < p; j++)
            {
                Console.WriteLine($"par[{j}] = " + par[j]);
            }
        }
    }
}
