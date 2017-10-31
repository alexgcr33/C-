using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC_
{
     class Menu
    {
        private string[] posibles = null;
        private bool exit = false;
        private int sel = 0;
        

        public Menu(string[] posibles)
        {
            this.posibles = posibles;
        }

        public bool cerrar() { return exit; }

        public void muestra()
        {
            Console.WriteLine(" Escoge entre las opciones!!");
            for (int i = 0; i < posibles.Length; i++)
            {

                Console.WriteLine(i +1+ " " + posibles[i]);

               
            }
            this.sel = Int32.Parse(Console.ReadLine());
        }

        public void select()
        {
            switch (this.sel)
            {
                case 1:
                    double real = 764.7834;
                    Console.WriteLine(" Te muestro por pantalla el numero " + Truncar(real) );
                    break;

                case 2:
                    double real1 = 764.7834;
                    int entero =  0 ;
                    TruncarV2(real1, ref entero);
                    Console.WriteLine(" Te muestro el entero " + entero );
                    break;

                case 3:
                    double real2 = 764.7834;
                    Console.WriteLine(" Te muestro el numero Truncado " + TruncarV3(ref real2));                     
                    break;

                case 4:
                    double real3 = 764.7834;
                    int redon = 2;
                    Console.WriteLine(" Te muestro el numero redondeado con 2 decimales " + TruncarV4(real3,ref redon));
                    break;

                case 5:
                    double real4 = 764.7834;
                    int redond = 3;
                    double conten = 0;
                    Console.WriteLine("El numero redondeado te lo paso a otro entero " + TruncarV5(real4, redond, conten));
                    break;

                case 6:
                    double real5 = 764.7834;
                    int escrito =0 ;
                    Console.WriteLine(" ¿Cuantos decimales quieres? (MAX 3) ");
                    escrito = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El numero redondeado por los decimales que has querido " + TruncarV6(real5,escrito ));
                    break;

                case 7:
                    this.exit = false;
                    break;
            }
        }
           
         public double Truncar(double numero)
        {

            return (int)numero;
        }

        public double TruncarV2(double numero, ref int entero)
        {
            return entero = (int)numero;

        }   
         
        public double TruncarV3( ref double numero)
        {
            return numero = Math.Truncate(numero);

        }
        
        public double TruncarV4(double numero, ref int redon)
        {

            return Math.Round(numero, redon);
        }

        public double TruncarV5(Double numero, int redon, double contenedor) {

            return contenedor = Math.Round(numero, redon);
            }

        public double TruncarV6(double numero, int elec)
        {
            return numero = Math.Round(numero, elec);
        }

        }


        
        



        }


        
            

        

        

        
    
    
        
    



