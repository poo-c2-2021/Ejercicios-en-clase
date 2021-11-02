using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosUI
{
    public class Auto
    {


        public int Litros
        {
            get { return this.litrosNafta; }
        }

        public event ReservaEvento prendeLaReserva;
        public event SinNaftaEvento aCaminar;

        private static int kilometrosPorLitro;

        private int litrosNafta;

        private int kilometros;

        private string nombreAuto;


        static Auto()
        {
            kilometrosPorLitro = 10;
            
        }


        public Auto(string auto, int litros)
        {
            this.litrosNafta = litros;
            this.nombreAuto = auto;
            this.kilometros = 0;
        }

        public string NombreAuto
        {
            get { return nombreAuto; }
            set { nombreAuto = value; }
        }


        public void recorrer(int kilometro)
        {
            for (int i = 0; i < kilometro; i++)
            {
                this.kilometros++;
                if (this.kilometros % kilometrosPorLitro == 0)
                {
                    this.litrosNafta--;
                    if (this.litrosNafta > 0 && this.litrosNafta < 5)
                    {
                        if (prendeLaReserva != null)
                        {
                            prendeLaReserva.Invoke();
                        }
                    }
                    if (this.litrosNafta == 0)
                    {
                        if (this.aCaminar != null)
                        {
                            this.aCaminar.Invoke();
                        }
                        break;
                    }

                }


            }
        }

        public void cargar()
        {
            this.litrosNafta = this.litrosNafta + 10;
        }

    }
}
