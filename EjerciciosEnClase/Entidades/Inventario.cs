using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {

        private List<Guitarra> stockGuitarras;

        public Inventario()
        {
            stockGuitarras = new List<Guitarra>() {
             new Guitarra(EMarca.Gibson,"Les Paul",500000),
             new Guitarra(EMarca.Fender,"Telecaster",300000),
             new Guitarra(EMarca.Cort,"SG",50000)
            };

        }


        public List<Guitarra> Guitarras
        {
            get
            {
                return stockGuitarras;
            }
        }

        public Guitarra this[int indice]
        {
            get
            {
                return stockGuitarras[indice];
            }
        } 
        
        public Guitarra this[string modelo]
        {
            get
            {
                foreach (Guitarra item in stockGuitarras)
                {
                    if(item.Modelo == modelo)
                    {
                        return item;
                    }
                }

                return null;
            }

            set
            {

                string ejemplo = modelo;
                 
                Guitarra unaGuitarra = value;


            }

        }




    }
}
