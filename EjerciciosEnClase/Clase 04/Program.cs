using System;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;

            int resultado = a + b;

            string s1 = "hola";
            string s2 = "Pepe";

            string frase = s1 + " " + s2;


            Aula aula1 = new Aula("2E");
            Aula aula2 = new Aula("2D");

            Alumno alumno1 = new Alumno("Pepe Peposo", 123);
            Alumno alumno2 = new Alumno("Pepe Peposo", 123);


            if(alumno1 == alumno2)
            {
                Console.WriteLine("IGUALES");
            }
            else
            {
                Console.WriteLine("DISTINTOS");
            }

            if (alumno1 != alumno2)
            {
                Console.WriteLine("DISTINTOS");
            }
            else
            {
                Console.WriteLine("IGUALES");
            }
        }
    }
}
