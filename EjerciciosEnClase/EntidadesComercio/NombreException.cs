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

        public override string Message {
            get
            {
                
                return "Nombre inválido " + base.Message ;
            }
        }
    }
}
