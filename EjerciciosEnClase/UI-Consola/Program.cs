using System;
using Entidades;


namespace UI_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroe miheroe = new Heroe("pepe", "volador", 10);

            string nombreHeroe2 = miheroe.GetNombre();

            // funciona como GET 
            string nombreHeroe = miheroe.Nombre;

            string deb = miheroe.Debilidad;


        }
    }
}
