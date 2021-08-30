using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T_Ej_03
{
    public class Cuenta
    {
        public string nombre;
        public float cantidad;

        public Cuenta(string nombre, float cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {this.nombre}");
            Console.WriteLine($"Cantidad: {this.cantidad}");
        }

        public void Ingresar(int cantidad)
        {
            if (cantidad > 0)
            {
              this.cantidad += cantidad;
            }            
        }

        public void Retirar(int cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad -= cantidad;
            }
        }

    }


}
