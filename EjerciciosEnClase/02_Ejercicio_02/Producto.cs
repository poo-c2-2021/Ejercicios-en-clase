using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ejercicio_02
{
    public class Producto
    {
        int codigo;
        string nombre;
        string marca;
        int precio;
        string categoria;


        public Producto(int codigo, string nombre, string marca, int prec)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.marca = marca;
            precio = prec;
            categoria = "Galletita";
        }


        public void SetCategoria(string categoria)
        {

            this.categoria = categoria;
        }


        public string GetCategoria()
        {

            return $"La categoria es : {categoria}";
        }
        public string GetNombre()
        {

            return $"El nombre es es : {nombre}";
        }

        public int GetCodigo()
        {
            return this.codigo;
        }


    }
}
