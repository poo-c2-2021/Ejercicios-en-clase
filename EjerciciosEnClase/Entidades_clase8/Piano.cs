using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_clase8
{
    public class Piano : InstrumentoMusical
    {
        public Piano(string modelo, string origen, int precio) : base(modelo, origen, precio)
        {
        }


        public string SoyUnPiano()
        {
            return "soy un pianito";
        }

    }
}
