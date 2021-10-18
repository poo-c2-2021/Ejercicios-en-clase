using System;
using System.Collections.Generic;
using System.Reflection;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>();
            List<Pintura> pinturas = new List<Pintura>();

            Galpon<Auto> galpon = new Galpon<Auto>();

            if  (galpon == null)
            {

            }

            Auto miAuto = new Auto();
            galpon = galpon + miAuto;
            miAuto.ElColor = ConsoleColor.Red;
            miAuto.Marca = "Fiat ";
            miAuto.Modelo = "600";
            autos.agregarAuto(miAuto);
            ExtenderLista.agregarAuto(autos, miAuto);
            //autos.agregarAuto(miAuto);

            Galpon<Pintura> galponPinturas = new Galpon<Pintura>();
            Pintura pintura = new Pintura();
            pintura.Color = ConsoleColor.Yellow;
            pintura.Litros = 20;
            pintura.Tipo = "Latex Exterior";
            galponPinturas = galponPinturas + pintura;



            MostrarEnPantalla<Auto>(miAuto);
            Avion miJet = new Avion();
            MostrarEnPantalla<Avion>(miJet);

            Console.ReadLine();
            
        }

        static T MostrarEnPantalla<T>(T valor) 
        {
            Type tipoActual = typeof(T);
            foreach (PropertyInfo item in tipoActual.GetProperties())
            {
                Console.WriteLine("{0} {1}", item.Name, item.GetValue(valor));

            }            
              return valor;

        }


        
    }
}
