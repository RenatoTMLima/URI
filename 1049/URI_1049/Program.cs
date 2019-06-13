using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2, s3, animal;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            s3 = Console.ReadLine();

            switch (s1)
            {
                case "vertebrado":
                    switch (s2)
                    {
                        case "ave":
                            switch (s3)
                            {
                                case "carnivoro":
                                    animal = "aguia";
                                    break;
                                default:
                                    animal = "pomba";
                                    break;
                            }
                            break;
                        default:
                            switch (s3)
                            {
                                case "onivoro":
                                    animal = "homem";
                                    break;
                                default:
                                    animal = "vaca";
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    switch (s2)
                    {
                        case "inseto":
                            switch (s3)
                            {
                                case "hematofago":
                                    animal = "pulga";
                                    break;
                                default:
                                    animal = "lagarta";
                                    break;
                            }
                            break;
                        default:
                            switch (s3)
                            {
                                case "hematofago":
                                    animal = "sanguessuga";
                                    break;
                                default:
                                    animal = "minhoca";
                                    break;
                            }
                            break;
                    }
                    break;
            }

            Console.WriteLine(animal);

            Console.ReadLine();
        }
    }
}
