using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public abstract class Persona
    {
        private double cuil;
        private string nombre;
        public double Cuil
        {
            get
            {
                return this.cuil;
            }
            set
            {
                if (validarCuil(value))
                {
                    this.cuil = value;
                }
                else
                {
                    CuilException cuilException = new CuilException();
                    cuilException.Cuil = cuil;
                    throw cuilException;
                    
                }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                string auxNombre = value;
                foreach (Char caracter in auxNombre.ToCharArray())
                {
                    if (Char.IsDigit(caracter))
                    {
                        NombreException nomEx = new NombreException(auxNombre)
                        nomEx.Nombre = nomEx;
                        throw Nombre;
                    }

                }
                this.nombre = auxNombre;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cuil"></param>
        /// <exception cref="PersonaException"></exception>
        public Persona(string nombre, double cuil)
        {
            try
            {
                this.Cuil = cuil;
                this.Nombre = nombre;
            }
            catch (Exception excp)
            {
                throw new PersonaException("Error al crear Persona", excp);
            }
        }

        public abstract string Mostrar();

        private bool validarCuil(double cuil)
        {
            char[] ponderador = { '5', '4', '3', '2', '7', '6', '5', '4', '3', '2' };
            int i;
            double suma = 0;
            char[] numero = cuil.ToString("00000000000").ToCharArray();
            for (i = 0; i < 10; i++)
            {
                suma += (int.Parse(ponderador[i].ToString()) * int.Parse(numero[i].ToString()));
            }

            suma = suma % 11;
            suma = 11 - suma;

            suma = suma == 10 ? 0 : suma == 11 ? 1 : suma;


            return suma == int.Parse(numero[10].ToString());

        }


    }
}
