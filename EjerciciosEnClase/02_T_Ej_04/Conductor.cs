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
        int[] kms;

        public Conductor(string nombre, int[] kms)
        {
            this.nombre = nombre;
            this.kms = kms;
        }

        public double KmTotales()
        {
            double aux=0;
            for (int i = 0; i < kms.Length; i++)
            {
                aux += kms[i];
            }
            return aux;
        }

        public int GetDia3()
        {
            return kms[2];
        }
        
        public int GetDia5()
        {
            return kms[4];
        }

        public string MostrarNombre()
        {
          return this.nombre;
        }
    }
}
