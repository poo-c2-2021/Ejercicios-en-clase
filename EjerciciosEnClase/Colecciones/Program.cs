using System;
using System.Collections.Generic;
using Entidades;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> listasNombres = new List<string>();

            string a = "pepe";
            listasNombres.Add(a);
            listasNombres.Add("carola");
            listasNombres.Add("juana");
            listasNombres.Add("dumbo");

            foreach (string item in listasNombres)
            {
               
                    Console.WriteLine(item);
                
            }

            listasNombres.Remove(a);

            Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine();


            foreach (string item in listasNombres)
            {
               
                    Console.WriteLine(item);
               

            }








            List<float> listFloat = new List<float>();

            listFloat.Add(12);
            listFloat.Add(14);





        }
    }
}
