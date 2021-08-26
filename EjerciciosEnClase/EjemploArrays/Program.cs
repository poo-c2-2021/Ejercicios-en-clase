using System;

namespace EjemploArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNombres;
            int[] numero = new int[1];

            numero[0] = 1;

            arrayNombres = new string[5];

            arrayNombres[0] = "Pepe";
            arrayNombres[1] = "Juana";
            arrayNombres[2] = "Romeo";
            arrayNombres[3] = "Betun";
            arrayNombres[4] = "Juanito";

            ModificarArray(arrayNombres);

            MostrarArray(arrayNombres);
        }


        static void ModificarArray(string[] arrayAux)
        {
            arrayAux[0] = "Lucas";

        }


        static void MostrarArray(string[] arrayAux)
        {

            for (int i = 0; i < arrayAux.Length; i++)
            {
                Console.WriteLine(arrayAux[i]);
            }

        }

    }
}
