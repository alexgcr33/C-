using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Fecha
    {
        private int dia;
        private int mes;
        private int anio;
        private string intro;
        #region publicas
        public Fecha(int d, int m, int a, string intr)
        {
            this.dia = d;
            this.mes = m;
            this.anio = a;
            this.intro = intr;
        }


        public Fecha(string fecha)
        {
            this.intro = fecha;
            ImportarFechaCadena(intro);

        }
        public int getAnio()
        {
            return this.anio;
        }

        public int getMes()
        {

            return this.mes;
        }

        public int getDia()
        {
            return this.dia;
        }
        public int setDia()
        {
            return this.dia;
        }
        public int setMes()
        {
            return this.mes;
        }

        //internal void ToString(string v)
        //{
          //  throw new NotImplementedException();
        //}

        public int setAnio()
        {
            return this.anio;
        }

        public Boolean AnioBisiesto()
        {

            if (this.anio % 4 == 0)
            {
                return true;

            }

            return false;
        }


        public String ACadena()
        {
            return dia.ToString("00") + "/" + mes.ToString("00") + "/" + anio.ToString("0000");  

        }

        public Fecha AumentarMes()
        {

           

            Fecha f = new Fecha(this.ACadena());
            f.AumentoMes();
            return f;
        }

        public Boolean EsMayor(Fecha fx)
        {
           if (this.anio > fx.getAnio())
            {
                return true;
            }else if(this.anio == fx.getAnio())
             {
                if(this.mes > fx.getMes())
                {
                    return true;


                }else if(this.mes == fx.getMes())
                {
                    if(this.dia == fx.getDia())
                    {
                        return true;

                    }else if(this.dia == fx.getDia())
                    {
                        return false;

                    }

                }

            }

            return false;
            
        }

        #endregion

        #region privadas
        private void ImportarFechaCadena(string fecha)
        {
            string[] trozos = fecha.Split('/');
            this.dia = int.Parse(trozos[0]);
            this.mes  = int.Parse(trozos[1]);
            this.anio = int.Parse(trozos[2]);


            }

        private void AumentoMes()
        {
            if (mes == 12)
            {
                mes = 1;
                anio++;
            }
            else

            mes++;

        }

        #endregion

    }
}
