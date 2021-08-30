using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T_Ej_02
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private int dni;

        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public string GetNombre() 
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }


        public int GetEdad()
        {
            return this.edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }


        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {this.GetNombre()}");            
            Console.WriteLine($"Edad: {this.GetEdad()}");
            Console.WriteLine($"DNI: {this.GetDni()}");
            this.EsMayorDeEdad();
        }

        public void EsMayorDeEdad()
        {
            if (this.edad < 18)
            {
                Console.WriteLine("Es menor de edad");
            }
            else
            {
                Console.WriteLine("Es mayor de edad");
            }
        }
    }
}
