using System;

namespace _02_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[3];

            Persona p1 = new Persona();
            Persona per2 = new Persona();

            p1.pass = "asd123";
            p1.usuario = "lala";

            per2.pass = "unaPersona2";
            per2.usuario = "cristobal colon";


            p1.MostrarInformacion();
            per2.MostrarInformacion();


            #region Codigo obsoleto
            //string[] usuarios = new string[3];
            //usuarios[0] = "juampi";
            //usuarios[1] = "caro";
            //usuarios[2] = "lucas";

            //string[] contras = { "eldossantos", "juani", "asd123" };

            //string usuario;
            //string password;
            //Console.WriteLine("Ingrese Usuario");
            //usuario = Console.ReadLine();

            //Console.Clear();
            //Console.WriteLine("Ingrese password");
            //password = Console.ReadLine();


            //for (int i = 0; i < usuarios.Length; i++)
            //{
            //    if (usuarios[i] == usuario)
            //    {
            //        if (contras[i] == password)
            //        {
            //            Console.WriteLine("usuario logueado");
            //        }
            //    }
            //}
            #endregion


        }
    }
}
