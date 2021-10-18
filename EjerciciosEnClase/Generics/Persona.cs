using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Persona
    {
        private long dni;

        private string apellido;

        private string nobre;

        public string Nombre
        {
            get { return nobre; }
            set { nobre = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public long DNI
        {
            get { return dni; }
            set { dni = value; }
        }


    }
}
