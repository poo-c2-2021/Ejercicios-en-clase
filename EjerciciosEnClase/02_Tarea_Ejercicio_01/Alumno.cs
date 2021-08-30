using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T_Ej_01
{
    public class Alumno
    {

        string nombre;
        string apellido;
        float nota1;
        float nota2;

        public Alumno(string nombre, string apellido, float nota1, float nota2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public float MostrarPromedio()
        {
            float suma = nota1 + nota2;

            return suma / 2;
        }

    }
}
