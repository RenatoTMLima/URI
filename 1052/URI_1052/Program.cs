using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = int.Parse(Console.ReadLine());
            string nome = "";

            switch (mes)
            {
                case 1:
                    nome = "January";
                    break;
                case 2:
                    nome = "February";
                    break;
                case 3:
                    nome = "March";
                    break;
                case 4:
                    nome = "April";
                    break;
                case 5:
                    nome = "May";
                    break;
                case 6:
                    nome = "June";
                    break;
                case 7:
                    nome = "July";
                    break;
                case 8:
                    nome = "August";
                    break;
                case 9:
                    nome = "September";
                    break;
                case 10:
                    nome = "October";
                    break;
                case 11:
                    nome = "November";
                    break;
                case 12:
                    nome = "December";
                    break;
            }

            Console.WriteLine(nome);
            Console.ReadLine();
        }
    }
}
