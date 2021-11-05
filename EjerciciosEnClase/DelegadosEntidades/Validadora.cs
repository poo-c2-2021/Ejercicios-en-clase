using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEntidades
{
    public class Validadora
    {
        public static bool Validar<T>(T aVerificar, Action<T> todoBien, Action<T> error) 
            where T : Ivalidadora
        {
            if (aVerificar.Validar())
            {
                
                todoBien.Invoke(aVerificar);
                return true;
            }
            else
            {
                error.Invoke(aVerificar);
            }
            return false;
        }

    }
}
