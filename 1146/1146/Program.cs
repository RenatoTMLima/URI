using System;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                for (int i = 1; i < n; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(n);
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
