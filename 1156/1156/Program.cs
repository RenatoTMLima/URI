using System;

namespace _1156
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double j=1, s=0, n=0;
            for (i = 1; i <= 39; i+=2)
            {
                s += (i / j);
                n++;
                j = Math.Pow(2, n);
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
