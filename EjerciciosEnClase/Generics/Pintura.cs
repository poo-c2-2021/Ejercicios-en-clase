using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class Pintura
    {
        private ConsoleColor color;

        private int litros;

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Litros
        {
            get { return litros; }
            set { litros = value; }
        }

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
