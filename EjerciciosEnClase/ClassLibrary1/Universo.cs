using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Universo
    {
        int cantidadHeroes;
        Heroe[] heroes;
        string nombre;


        public Universo(int cantidadDeHeroes, string nombre)
        {
            if (cantidadDeHeroes > 0)
                this.cantidadHeroes = cantidadDeHeroes;
            this.heroes = new Heroe[cantidadDeHeroes];
            this.nombre = nombre;
        }

        public static explicit operator Universo(int cantidad)
        {
            return new Universo(cantidad, "sin nombre");
        }

        public static implicit operator Universo (Heroe heroe)
        {
            Universo universo = new Universo(20,"mi Universo");
            AgregarHeroe(universo, heroe);
            return universo;
        }

        public static explicit operator Heroe (Universo universo)
        {  
            return universo.heroes[0];
        }


        public static bool operator +( Universo universo, Heroe heroe)
        {
            for (int i = 0; i < universo.heroes.Length; i++)
            {
                if (universo.heroes[i] is null)
                {
                    universo.heroes[i] = heroe;
                    return true;
                }
            }

            return false;
        }

        public static bool AgregarHeroe(Universo universo, Heroe heroe)
        {
            return universo + heroe;
        }

            public static string Enfentar(int posicion, int posicion2, Universo universo)
        {
            if (posicion > universo.heroes.Length || posicion2 > universo.heroes.Length || posicion < 0 || posicion2 < 0)
                return "";
            if (universo.heroes[posicion] is null || universo.heroes[posicion2] is null)
                return "";


            if (universo.heroes[posicion].GetEsAyudante() != universo.heroes[posicion2].GetEsAyudante())
            {
                if (universo.heroes[posicion].GetEsAyudante())
                    return universo.heroes[posicion].GetNombre();
                else
                    return universo.heroes[posicion2].GetNombre();
            }

            if (universo.heroes[posicion].GetNivelFuerza() > universo.heroes[posicion2].GetNivelFuerza())
                return universo.heroes[posicion].GetNombre();
            else
                return universo.heroes[posicion2].GetNombre();



            
        }


    }
}
