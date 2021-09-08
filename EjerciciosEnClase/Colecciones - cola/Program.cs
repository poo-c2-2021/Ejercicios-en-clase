using System;
using System.Collections;
using System.Collections.Generic;

namespace Colecciones___cola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pacientes = new List<string>();

            pacientes.Add("carola");
            pacientes.Add("juana");
            pacientes.Add("dumbo");

            Queue<string> colaPacientes = new Queue<string>(pacientes);

            colaPacientes.Enqueue("Romeo");

            Console.WriteLine(colaPacientes.Peek());

           string variable =  colaPacientes.Dequeue();

            Console.WriteLine(colaPacientes.Peek());


            //foreach (string item in colaPacientes)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
