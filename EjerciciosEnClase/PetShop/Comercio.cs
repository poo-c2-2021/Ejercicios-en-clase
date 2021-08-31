using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public static class Comercio
    {

        static string nombre;
        static string direccion;
        static long cuit;
        static string razonSocial;
        static Factura[] facturas;


        static Comercio()
        {
            nombre = "Firulais";
            direccion = "San Martin 455 ";
            cuit = 30445889964;
            razonSocial = "Lucas Rodriguez";

        }

        public static string GetNombre()
        {
            return nombre;
        }

        public static void SetNombre(string nombre)
        {
            Comercio.nombre = nombre;
        }

        public static long GetCuit()
        {
            return cuit;
        }
        public static string GetDireccion()
        {
            return direccion;
        }
        public static string GetRazonSocial()
        {
            return razonSocial;
        }

    }
}
