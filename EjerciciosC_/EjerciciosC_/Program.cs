using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC_
{
    class Program
    {
        static void Main(string[] argv)
        {
            double num1= 764.7834;
            double num2 = 0;
            int num3 = 0;
            
            string[] posibles = {
                "Dame un real y devuelve un numero sin decimales",
                "Dame un real y entero", "Dar un real ", "Dar real y entero ",
                "Dar real, entero y real ", "Dar real y entero " , "Salir"
            };
           

            Menu menu = new Menu(posibles);
           
            do
            {
                Console.Clear();
                menu.muestra();
                menu.select();

                Console.ReadKey();


            } while (menu.cerrar() != false); 

            //Console.ReadKey();

            
        }

    }

}