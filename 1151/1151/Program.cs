using System;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, b, c;
            a = 0;
            b = 1;
            c = a + b;

            if (n == 1)
            {
                Console.WriteLine("0");
            }else if (n == 2)
            {
                Console.WriteLine("0 1");
            }
            else
            {
                Console.Write("0 1");
                for (int i = 2; i < n-1; i++)
                {
                    Console.Write(" " + c);
                    a = b;
                    b = c;
                    c = a + b;
                }
                Console.WriteLine(" " + c);

            }
        }
    }
}
