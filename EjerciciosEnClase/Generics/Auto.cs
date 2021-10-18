using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Auto:Vehiculo
    {
        private ConsoleColor elColor;

        public ConsoleColor ElColor
        {
            get { return elColor; }
            set { elColor = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }


        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public override string mostrar()
        {
            return this.elColor.ToString() + " " + this.marca + " " + this.modelo;
        }
    }
}
