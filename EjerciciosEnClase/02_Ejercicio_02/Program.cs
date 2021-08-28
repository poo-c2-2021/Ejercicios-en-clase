using System;

namespace _02_Ejercicio_02
{

    class Program
    {
        static void Main(string[] args)
        {

            Producto[] inventario = new Producto[2];

            CargarInfoInicial(inventario);

            for (int i = 0; i < inventario.Length; i++)
            {
                Console.WriteLine(inventario[i].GetNombre()); // GET 
                Console.WriteLine(inventario[i].GetCategoria()); // GET 
                Console.WriteLine(); // GET 
            }
        }

        static void CargarInfoInicial(Producto[] auxInventario)
        {
            string marcaIngresada = "Arcor";
            Producto prod1 = new Producto(10, "Pitusas", "Marolio", 50);
            Producto prod2 = new Producto(211, "Opera", marcaIngresada, 100);

            auxInventario[0] = prod1;
            auxInventario[1] = prod2;

        }

    }

}
