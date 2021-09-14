using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guitarra
    {

        private string marca ;

        private string modelo;

        private int precio;

        public Guitarra(string marca, string modelo, int precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Marca
        {
            get { return marca ; }
            set { marca  = value; }
        }



    }
}
