using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T_Ej_04
{
    public class Empresa
    {

        string nombreEmpresa;
        Conductor[] conductores;

        public Empresa(string nombre)
        {
            this.nombreEmpresa = nombre;
            conductores = new Conductor[3];
        }

        public void AgregarConductor(Conductor auxConductor)
        {
            for (int i = 0; i < conductores.Length; i++)
            {
                if(conductores[i] == null)
                {
                    conductores[i] = auxConductor;
                    break;
                }
            }

        }



    }
}
