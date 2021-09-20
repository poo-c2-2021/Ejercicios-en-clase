using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public  class Empleado : Persona
    {

        public float Sueldo { get; set; }
        public Empleado(string nombre, double cuil, float sueldo) : base(nombre, cuil)
        {
            this.Sueldo = sueldo;
        }

        public override string Mostrar()
        { 
            return $"nom:{this.Nombre} cuil:{this.Cuil}" + " sue:" + this.Sueldo.ToString();
        }

        #region conTema


        public override string ToString()
        {
            return this.Mostrar();
        }

        public virtual void Aumentar(int porcentaje)
        {
            this.Sueldo = this.Sueldo + this.Sueldo * porcentaje / 100;

        }
        #endregion

        public void AumentarEmpleado(int porcentaje)
        {
            this.Sueldo = this.Sueldo + this.Sueldo * porcentaje / 100;

        }
    }
}
