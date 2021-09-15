using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_clase8
{
    public class GuitarraCriolla : Guitarra
    {

        bool tieneCorte;


        public GuitarraCriolla(EMarca marca, string modelo, string origen, int precio,bool corte) : base(marca, modelo, origen, precio)
        {
            this.tieneCorte = corte;
        }


        public string Cancion()
        {
            return "Alta chacarera";
        }


    }
}
