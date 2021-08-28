using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ejercicio_01
{
    public class Persona
    {
        // ATRIBUTO
        public string usuario;
        public string pass;

        // METODOS   (COMPORTAMIENTO)
        public void MostrarInformacion()
        {
            Console.WriteLine(usuario);
            Console.WriteLine(pass);
        }


    }
}
