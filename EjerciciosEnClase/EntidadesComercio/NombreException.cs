using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public class NombreException:Exception
    {
        public NombreException(string mensajeDeError): base(mensajeDeError)
        {

        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public override string Message {
            get
            {
                
                return "Nombre inválido " + base.Message ;
            }
        }
    }
}
