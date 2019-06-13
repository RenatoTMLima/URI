using System;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MinValue, b = 0, c;

            for (int i = 0; i < 100; i++)
            {
                c = int.Parse(Console.ReadLine());
                if (a < c)
                {
                    a = c;
                    b = i+1;
                }
            }
            Console.WriteLine(a + "\n" + b);
        }
    }
}
