using System;
using System.Collections;
using System.Collections.Generic;
using Entidades;


namespace Colecciones___Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> aula1 = new List<string>();

            aula1.Add("carola");
            aula1.Add(null);
            aula1.Add("juana");
            aula1.Add("dumbo");

            Stack<string> pilaApellidos = new Stack<string>(aula1);

            pilaApellidos.Push("juancho");
            pilaApellidos.Push("Tincho");



            Console.WriteLine(pilaApellidos.Peek() +" "+ pilaApellidos.Count);
            Console.WriteLine(pilaApellidos.Peek() + " " + pilaApellidos.Count);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(pilaApellidos.Pop() + " " + pilaApellidos.Count);
            Console.WriteLine(pilaApellidos.Pop() + " " + pilaApellidos.Count);
            Console.WriteLine(pilaApellidos.Peek() + " " + pilaApellidos.Count);
            Console.WriteLine(pilaApellidos.Peek() + " " + pilaApellidos.Count);


            string[] array = pilaApellidos.ToArray();




            foreach (string item in pilaApellidos)
            {
                Console.WriteLine(item);
            }




        }
    }
}
