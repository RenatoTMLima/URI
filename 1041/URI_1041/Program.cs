﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] vet = Console.ReadLine().Split(' ');

            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            if (x==0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else
                {
                    Console.WriteLine("Q4");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }
            Console.ReadLine();
        }
    }
}