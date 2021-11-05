using System;

namespace DelegadosEntidades
{
    public class Class1 : Ivalidadora
    {
        Auto auto;
        public Class1()
        {

        }
        bool Ivalidadora.Validar()
        {
            return this.auto != null;
        }
    }
}
