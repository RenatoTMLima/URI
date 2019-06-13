using System;

namespace URI1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int cont, pos;
            pos = cont = 0;

            do
            {
                num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    pos++;
                }
                cont++;
            } while (cont < 6);
            Console.WriteLine(pos + " valores positivos");
        }
    }
}
