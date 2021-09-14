using System;

namespace Entidades
{
    public class Cliente
    {

        private int id;
        private string nombre;
        private Guitarra guitarra;

        private static Cliente clienteHistorico;
        private static int ultimoIdRegistrado;

        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
         
        public Guitarra Instrumento
        {
            get { return guitarra; }
            set { guitarra = value; }
        }


        public static Cliente MejorCliente
        {
            get
            {
                return clienteHistorico;
            }
        }



        static Cliente()
        {
            ultimoIdRegistrado = 0;
            clienteHistorico = null;
        }

        private Cliente()
        {
            ultimoIdRegistrado++;
            this.id = ultimoIdRegistrado;
        }

        public Cliente(string nombre):this()
        {
            this.nombre = nombre; // set 
        }
        
        public Cliente(string nombre, Guitarra guitarra):this(nombre)
        {
            this.guitarra = guitarra;
        }



    }
}
