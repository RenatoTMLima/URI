using System;

namespace URI1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma = 0.0;
            int cont, pos;
            pos = cont = 0;

            do
            {
                num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    soma += num;
                    pos++;
                }
                cont++;
            } while (cont < 6);

            Console.WriteLine(pos + " valores positivos");
            Console.WriteLine((soma/pos).ToString("F1"));
        }
    }
}
