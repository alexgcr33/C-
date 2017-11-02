using ConsoleApplication4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha_ejer
{
    class Program
    {
        static void Main(string[] args)
        {

            int sel = 0;

            do
            {
                Console.WriteLine("Bienvenido a las fechas, escoge una opcion");
                Console.WriteLine("1.Sumar Mes");
                Console.WriteLine("2.Si es bisiesto");
                Console.WriteLine("3.Comparar 3 fechas");
                Console.WriteLine("4.Salir");

                sel = Int32.Parse(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        {

                            string fex = null;
                            Console.WriteLine("Dame una fecha con el formato DD/MM/AAAA");
                            fex = (Console.ReadLine());


                            Fecha f1 = new Fecha(fex);



                            // f1.ACadena();
                            f1 = f1.AumentarMes();
                            Console.WriteLine(f1.ACadena());
                            Console.ReadKey();
                            Console.Clear();



                            break;
                        }
                    case 2:
                        {
                            string flex = null;
                            Console.WriteLine("Dame una Fecha: (Formato DD/MM/AAAA)");
                            flex = (Console.ReadLine());

                            Fecha f1 = new Fecha(flex);

                            if (f1.AnioBisiesto() == true)
                            {
                                Console.WriteLine("El año es bisiesto");
                            }
                            else
                            {
                                Console.WriteLine("No es bisiesto");
                            }

                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }
                    case 3:
                        {
                            string flex1 = null;
                            string flex2 = null;
                            string flex3 = null;
                            Console.WriteLine("Dame una Fecha para 1: (Formato DD/MM/AAAA)");
                            flex1 = Console.ReadLine();
                            Console.WriteLine("Dame una Fecha para 2: (Formato DD/MM/AAAA)");
                            flex2 = Console.ReadLine();
                            Console.WriteLine("Dame una Fecha para 3: (Formato DD/MM/AAAA)");
                            flex3 = Console.ReadLine();

                            Console.Clear();
                            Fecha f1 = new Fecha(flex1);
                            Fecha f2 = new Fecha(flex2);
                            Fecha f3 = new Fecha(flex3);

                            if (f1.EsMayor(f2) == true)
                            {
                                if (f1.EsMayor(f3) == true) ;
                                if (f2.EsMayor(f3) == true)
                                {
                                    Console.WriteLine(f1.ACadena());
                                    Console.WriteLine(f2.ACadena());
                                    Console.WriteLine(f3.ACadena());
                                }
                                else
                                {
                                    Console.WriteLine(f1.ACadena());
                                    Console.WriteLine(f3.ACadena());
                                    Console.WriteLine(f2.ACadena());
                                }

                            }
                            else if (f2.EsMayor(f3) == true)
                            {
                                if (f3.EsMayor(f1) == true)
                                {
                                    Console.WriteLine(f2.ACadena());
                                    Console.WriteLine(f3.ACadena());
                                    Console.WriteLine(f1.ACadena());
                                }
                                else
                                {
                                    Console.WriteLine(f2.ACadena());
                                    Console.WriteLine(f1.ACadena());
                                    Console.WriteLine(f3.ACadena());

                                }
                            }

                                if (f2.EsMayor(f1))
                                {
                                    Console.WriteLine(f3.ACadena());
                                    Console.WriteLine(f2.ACadena());
                                    Console.WriteLine(f1.ACadena());
                                }
                                else
                                {
                                    Console.WriteLine(f3.ACadena());
                                    Console.WriteLine(f1.ACadena());
                                    Console.WriteLine(f2.ACadena());
                                }


                                
                        }
                                Console.ReadKey();
                        Console.Clear();
                                break;
                            
                    case 4:
                        {
                            break;
                        }
                    default: { break; }

                }






            } while (sel != 4);






        }
    }
}
