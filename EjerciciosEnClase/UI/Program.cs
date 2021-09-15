using System;
using System.Collections.Generic;
using Entidades_clase8;


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {

            Guitarra guitarra = new Guitarra(EMarca.Epiphone, "les paul", "argentina", 2000);

            Piano unPiano = new Piano("teclita feliz", "Canada", 99999);

            InstrumentoMusical instru = new InstrumentoMusical("asd123", "Chile", 1000);


            List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();

            instrumentos.Add(guitarra);
            instrumentos.Add(unPiano);
            instrumentos.Add(instru);
            instrumentos.Add(new GuitarraCriolla(EMarca.Texas, "criolla", "chaco", 500, true));



            foreach (InstrumentoMusical item in instrumentos)
            {


                if (item is Guitarra)
                {
                    Console.WriteLine(((Guitarra)item).Marca);
                }

                else if (item is Piano)
                {
                    Console.WriteLine(((Piano)item).SoyUnPiano());
                }
                else if (item is GuitarraCriolla)
                {
                    Console.WriteLine(((GuitarraCriolla)item).Cancion());

                }


                    Console.WriteLine(item.Informacion);

            }


        }
    }
}
