using System;

namespace _02_Tarea_Ejercicio_01
{
    class Program
    {

        #region Enunciado
        /*
                Crear la clase Alumno que contenga la siguiente información:
                Atributos:
        
                            •nombre
                            •apellido
                            •nota1
                            •nota2
               Constructor: 
               Deberá tener unconstructor que permita cargarle informacióna los 4 atributos.
              
               Métodos: 
               El método “mostrar promedio” deberá mostrar el promedio de las notas del alumno.
               Cargar 3 alumnosen el mainy mostrarlos por pantalla.
          
          */


        #endregion
        static void Main(string[] args)
        {

            Alumno a1 = new Alumno("Caro", "Lina", 10, 9);
            Alumno a2 = new Alumno("Juan", "Pablo", 8, 7);
            Alumno a3 = new Alumno("Eze", "Quiel", 9, 6);

            Console.WriteLine($"Promedio alumno 1:  {a1.MostrarPromedio()}");
            Console.WriteLine($"Promedio alumno 1:  {a2.MostrarPromedio()}");
            Console.WriteLine($"Promedio alumno 1:  {a3.MostrarPromedio()}");


        }
    }
}
