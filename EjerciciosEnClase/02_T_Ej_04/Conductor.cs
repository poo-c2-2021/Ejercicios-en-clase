using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T_Ej_04
{
    public class Conductor
    {
        string nombre;
        public int[] kms;

        public Conductor(string nombre)
        {
            this.nombre = nombre;
            kms = new int[7];
        }

        public Conductor(string nombre,int[] kmsCargados)
        {
            this.nombre = nombre;
            this.kms = kmsCargados;
        }



        public void CargarKm(int km, int dia)
        {
            kms[dia - 1] = km;
        }







    }
}
