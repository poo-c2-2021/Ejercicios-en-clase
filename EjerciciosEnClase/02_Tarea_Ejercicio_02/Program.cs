using System;

namespace _02_T_Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona primeraPersona = new Persona("Lucas", 32, 30666666);
            Persona segundaPersona = new Persona("Ezequiel", 35, 32666666);
            Persona terceraPersona = new Persona("Juampi", 12, 40666666);

            primeraPersona.Mostrar();
            segundaPersona.Mostrar();
            terceraPersona.Mostrar();
        }
    }
}
