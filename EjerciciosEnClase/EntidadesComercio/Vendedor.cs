using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public class Vendedor : Empleado
    {
        public int Objetivo { get; set; }
        public Vendedor(string nombre, double cuil, float sueldo, int objetivo) : base(nombre, cuil, sueldo)
        {
            this.Objetivo = objetivo;
        }

        #region conTema
        public override string Mostrar()
        {
            return "soy vendedor";
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

        public override void Aumentar(int porcentaje)
        {
            base.Aumentar(porcentaje);
            this.Objetivo = this.Objetivo + this.Objetivo * porcentaje / 100;
        }
        #endregion

        public void AumentarVendedor(int porcentaje)
        {
            this.AumentarEmpleado(porcentaje);
            this.Objetivo = this.Objetivo + this.Objetivo * porcentaje / 100;
        }

      

    }
}
