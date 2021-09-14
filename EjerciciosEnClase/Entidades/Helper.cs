using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class Helper
    {


        private static double iva;

        static Helper()
        {
            iva = 1.21;
        }

        public static double Iva
        {
            get
            {
                return iva;
            }
        }

    }
}
