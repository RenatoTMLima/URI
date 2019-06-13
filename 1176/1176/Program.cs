using System;

namespace _1176
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            long[] Fib;

            for (int i = 0; i < T; i++)
            {
                int F = int.Parse(Console.ReadLine());
                Fib = new long[F+1];
                if (F == 0)
                {
                    Console.WriteLine("Fib(0) = 0");
                }else if(F == 1)
                {
                    Console.WriteLine("Fib(1) = 1");
                }
                else
                {
                    Fib[0] = 0;
                    Fib[1] = 1;
                    for (int j = 2; j <= F; j++)
                    {
                        Fib[j] = Fib[j - 1] + Fib[j - 2];
                    }
                    Console.WriteLine($"Fib({F}) = {Fib[F]}");
                }
            }
        }
    }
}
