using System;
using System.Collections.Generic;
using Entidades;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> aulaAux = new List<string>()
            {
                "martin","martina","rodolfa","eusebio"
            };
           
            aulaAux.Add("nico");




            List<string> aula1 = new List<string>();


            aula1.Add("carola");
            aula1.Add("juana");
            aula1.Add("dumbo");

            List<string> aula2 = new List<string>(aula1);

            aula2 = aula1;

            aula2.AddRange(aulaAux);

            aula1.RemoveAt(1);

            foreach (string item in aula1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");
            
            foreach (string item in aula2)
            {
                Console.WriteLine(item);
            }




        }
    }
}
