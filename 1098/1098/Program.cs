using System;

namespace _1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, j;

            do
            {
                for (int i = 1; i < 4; i++)
                {
                    j = (double)i + a;
                    Console.WriteLine("I={0} J={1}", a, j);
                }
                a += 0.2;
            } while (a <= 2.0);
        }
    }
}
