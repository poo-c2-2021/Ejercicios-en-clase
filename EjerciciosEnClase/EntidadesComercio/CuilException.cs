using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public class CuilException : Exception
    {
        private double cuil;

        public double Cuil
        {
            get { return cuil; }
            set { cuil = value; }
           
        }

    }
}
