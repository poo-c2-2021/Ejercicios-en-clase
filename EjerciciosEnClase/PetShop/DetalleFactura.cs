using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class DetalleFactura
    {
        int cantidad;
        string descripcion;
        float precioUnitario;

        public DetalleFactura(int cantidad, string descripcion, float precioUnitario)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
        }

        public float TotalDetalle()
        {
            return this.cantidad * this.precioUnitario;
        }

        public string DatosDetalle()
        {
            return $" {this.cantidad} de  {this.descripcion} $ {this.precioUnitario}  | {this.TotalDetalle()}";
        }

    }
}
