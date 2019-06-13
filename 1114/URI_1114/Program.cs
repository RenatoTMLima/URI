using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = int.Parse(Console.ReadLine());
            
            while(pass != 2002)
            {
                Console.WriteLine("Senha Invalida");
                pass = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            Console.ReadLine();
        }
    }
}
