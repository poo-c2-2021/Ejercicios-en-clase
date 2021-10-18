using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class ExtenderLista
    {
        public static void agregarAuto(this List<Auto> autos, Auto miAuto)
        {
            autos.Add(miAuto);
        }

    }
}
