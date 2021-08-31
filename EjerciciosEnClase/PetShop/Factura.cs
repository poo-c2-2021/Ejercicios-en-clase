using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class Factura
    {
        private static int numeroMaximo;
        int numero;
        DateTime fecha;
        DetalleFactura[] detalles;
        
        static Factura()
        {
            numeroMaximo = 1;
        }

        public int GetMaximo()
        {
            return numeroMaximo;
        }

        public Factura(DateTime fecha, DetalleFactura[] detalles)
        {
            this.numero = numeroMaximo +1 ;
            this.fecha = fecha;
            this.detalles = detalles;
            numeroMaximo = this.numero;
        }
        


        public float CalcularTotal()
        {
            float total = 0;
            for (int i = 0; i < detalles.Length; i++)
            {
                total += detalles[i].TotalDetalle();
            }
            return total;
        }

        public string RetornarFactura()
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Comercio.GetNombre());
            stringBuilder.Append(" " + Comercio.GetCuit().ToString());
            stringBuilder.AppendLine(" " + Comercio.GetDireccion());
            stringBuilder.AppendFormat(" numero: {0} Fecha {1} ", this.numero, this.fecha.ToString("dd/MM/yyyy"));

            for (int i = 0; i < detalles.Length; i++)
            {
                stringBuilder.AppendLine(detalles[i].DatosDetalle());
            }

            stringBuilder.AppendLine($"total {this.CalcularTotal()}");

            return stringBuilder.ToString();

        }

    }
}
