using System;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                num++;
            }

            for(int i = num; i <= num + 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
