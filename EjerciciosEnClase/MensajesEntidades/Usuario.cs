using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
   public class Usuario
    {
        private int id;

        private string usuario;

        private string pass;


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }


        public string NombreUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
