using System;
using System.Collections.Generic;
using Entidades;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {

            Heroe h1 = new Heroe("Batman", "Crack", 100);
            Heroe h2 = new Heroe("Acuaman", "Gritar", 20);
            Heroe h3 = new Heroe("Flash", "Correr", 45);

            Heroe[] arrayHeroes = { h1, h2, h3 };

            Heroe[] arrayHeroes2 = new Heroe[3];




            List<string> listaNombres = new List<string>();

          





            Universo universo;
            Heroe miHeroe;

            universo = h1;
            bool salida =universo + h2;
            salida = universo + h3;


            universo = (Universo)6;

            miHeroe = (Heroe)universo; 

            Console.WriteLine(h1.HeroeToString());
            Console.WriteLine(h2.HeroeToString());
            Console.WriteLine(h3.HeroeToString());

        }
    }
}
