using System;

namespace _1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            for (int i = 1; i < 10; i += 2)
            {
                for (int j = a; j >= a-2; j--)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
                a += 2;
            }
        }
    }
}
