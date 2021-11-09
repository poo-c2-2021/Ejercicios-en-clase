using EntidadesHilos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HilosUI
{
    public class NumeroLabel : Label
    {
        private Numero numero;
        public event CaidoDelegate perdido;

        public int Valor
        {
            get
            {
                return this.numero.Valor;
            }

        }

        public NumeroLabel()
        {
            this.numero = new Numero();
            this.Top = 0;
            this.Left = this.numero.PosX;
            this.Text = this.Valor.ToString();
            this.numero.Caido += this.perdio;
        }

        public void perdio()
        {

            perdido.Invoke();
        }

        public async Task Mover(CancellationToken ct)
        {
            await Task.Run(() =>
            {

                while (true)
                {
                    Thread.Sleep(100);
                    if (ct.IsCancellationRequested)
                    {

                        ct.ThrowIfCancellationRequested();
                    }
                    this.Invoke((MethodInvoker)(() =>
                    {                    
                        this.numero.Caer();
                        this.Top = this.numero.PosY;
                    }));
                }
            },ct);

        }
    }
}
