using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Alumno
    {

        string nombre;
        int dni;

        public Alumno(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
     

        public static bool operator == (Alumno a1, Alumno a2)
        {
            return a1.dni == a2.dni;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static explicit operator Alumno(Aula aula)
        {
            return new Alumno("",123);
        }

    }
}
