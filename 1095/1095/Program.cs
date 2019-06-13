using System;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            for (int i = 60; i >= 0; i-=5)
            {
                Console.WriteLine("I={0} J={1}", j, i);
                j += 3;
            }
        }
    }
}
