using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_clase8
{
    public  class InstrumentoMusical 
    {

        private string modelo;
        private string origen;
        private int precio;

        public InstrumentoMusical(string modelo, string origen, int precio)
        {
            this.modelo = modelo;
            this.origen = origen;
            this.precio = precio;
        }


        public string Origen
        {
            get
            {
                return this.origen;
            }
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


        public string Informacion
        {
            get
            {
                return $"{this.origen} , {this.modelo} \n";
            }
        }


    }
}
