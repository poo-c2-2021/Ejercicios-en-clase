using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guitarra
    {

        private EMarca marca;

        private string modelo;

        private int precio;

        public Guitarra(EMarca marca, string modelo, int precio)
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
        public EMarca Marca
        {
            get { return marca ; }
            set { marca  = value; }
        }

        public override string ToString()
        {
            return $"{this.marca} , {this.modelo}";
        }

    }
}
