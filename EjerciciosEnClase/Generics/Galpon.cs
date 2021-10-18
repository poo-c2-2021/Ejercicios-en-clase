using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Galpon<T>
    {
        public void agregarALista(object valor)
        {
            lista.Add((T)valor);
        }
        public static bool operator ==(Galpon<T> galpon, Galpon<T> galpon2)
        {
            if (galpon is null || galpon2 is null)
                return false;
            return galpon.ToString() == galpon2.ToString();
        }

        public static bool operator !=(Galpon<T> galpon, Galpon<T> galpon2)
        {

            return !(galpon == galpon2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Galpon<T>)
            {
                return this == (Galpon<T>)obj;
            }

            return false;
        }

        

        public Galpon(int Tamaño)
        {

        }

        List<T> lista;

        public Galpon()
        {
            this.lista = new List<T>();
        }

        public T obtenerPrimero()
        {
            return lista[0];
        }

        public static Galpon<T> operator +(Galpon<T> galpon, T item)
        {
            galpon.lista.Add(item);
            return galpon;
        }

    }
}
