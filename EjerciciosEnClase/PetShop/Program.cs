using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;

            Console.WriteLine("Ingrese la cantidad de items");
            string cantidadString = Console.ReadLine();



            int.TryParse(cantidadString, out cantidad);
            Factura[] factura = new Factura[3];
            DetalleFactura[] detalles = new DetalleFactura[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto");
                string auxNombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de items");
                string auxCantProducto = Console.ReadLine();
                Console.WriteLine("Ingrese el precio unitario");
                string auxPrecioUnit = Console.ReadLine();

                detalles[i] = new DetalleFactura(int.Parse(auxCantProducto), auxNombre, float.Parse(auxPrecioUnit));
            }

            factura[0] = new Factura(new DateTime(), detalles);
            factura[1] = new Factura(new DateTime(), detalles);
            factura[2] = new Factura(new DateTime(), detalles);


            Console.WriteLine(factura[0].RetornarFactura());
            Console.WriteLine(factura[1].RetornarFactura());
            Console.WriteLine(factura[2].RetornarFactura());

            Console.ReadLine();

        }
    }
}
