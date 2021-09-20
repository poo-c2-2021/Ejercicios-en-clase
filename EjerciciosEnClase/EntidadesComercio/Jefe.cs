using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public class Jefe : Empleado
    {
        public int Bono { get; set; }
        public Jefe(string nombre, double cuil, float sueldo, int bono) : base(nombre, cuil, sueldo)
        {
            this.Bono = bono;
        }
        public  void AumentarJefe(int porcentaje)
        {
            base.AumentarEmpleado(porcentaje);
            this.Bono = this.Bono * porcentaje / 100;
        }
        public override void Aumentar(int porcentaje)
        {
            base.AumentarEmpleado(porcentaje);
            this.Bono = this.Bono * porcentaje / 100;
        }

        #region conTema
        public override string Mostrar()
        {
            return base.Mostrar() + " Bon:" + this.Bono;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
