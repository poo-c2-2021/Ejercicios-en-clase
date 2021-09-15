using System;

namespace Entidades_clase8
{

    public enum EMarca
    {
        Gibson = 1930,
        Fender = 1899,
        Epiphone = 1950,
        Texas = 2000,
        Cort = 2001
    }


    public class Guitarra : InstrumentoMusical
    {

        private EMarca marca;

        public Guitarra(EMarca marca, string modelo,string origen, int precio):base(modelo,origen,precio)
        {
            this.marca = marca;
        }

    
        public EMarca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

    }
}
