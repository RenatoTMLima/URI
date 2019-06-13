using System;

namespace _1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0;
            for (int i = 1; i <= 100; i++)
            {
                s = s + (1 / (double)i);
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
