using System;
using System.Collections.Generic;
using Entidades;

namespace Colecciones___Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ejemplo 1
            //Dictionary<int, string> usuarios = new Dictionary<int, string>();


            //usuarios.Add(12, "Pepe");
            //usuarios.Add(12, "Juana");
            //usuarios.Add(10, "Dumbo");
            //usuarios.Add(5, "Kira");

            //string valor;



            //if (usuarios.TryGetValue(13, out valor))
            //{
            //    Console.WriteLine(valor);
            //}
            //else
            //{
            //    Console.WriteLine(valor);
            //    Console.WriteLine("NO EXISTE");
            //}



            //foreach (KeyValuePair<int, string> item in usuarios)
            //{
            //    if (item.Key > 11)
            //        Console.WriteLine($" id:{item.Key}  - user: {item.Value}  ");
            //}


            #endregion


            Dictionary<int, Heroe> dicHeroes = new Dictionary<int, Heroe>();

            Heroe h1 = new Heroe("pepe", "llegar a las 18:30", 5);

            dicHeroes.Add(1, h1);
            dicHeroes.Add(2, new Heroe("Juana","pasear",4));


            foreach (KeyValuePair<int, Heroe> info in dicHeroes)
            {
                if(info.Value.GetNombre() == "Juana")
                {

                }


            }


        }
    }
}
