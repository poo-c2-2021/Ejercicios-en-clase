using EntidadesHilos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HilosUI
{
    public partial class FrmPPal : Form
    {
        List<Task> tareas;
        Dictionary<string, CancellationTokenSource> cancellationTokenSource;
        public FrmPPal()
        {
            InitializeComponent();
            Numero.limiteY = this.Height;
            Numero.limiteX = this.Width;
        }



        private void Comenzar()
        {
            this.tareas = new List<Task>();
            this.cancellationTokenSource = new Dictionary<string, CancellationTokenSource>();

            for (int i = 0; i < 10; i++)
            {

                Thread.Sleep(500);

                CancellationTokenSource ct = new CancellationTokenSource();
                NumeroLabel numeroLabel = new NumeroLabel();
                numeroLabel.Name = $"lbl{tareas.Count}";
                numeroLabel.perdido += perdio;
                this.Invoke((Action)((() => this.Controls.Add(numeroLabel))));
                this.cancellationTokenSource.Add(numeroLabel.Name, ct);
                tareas.Add(Task.Run(() => numeroLabel.Mover(ct.Token), ct.Token));
            }

            Thread.Sleep(100*this.Height);

            this.Invoke((Action)((() => MessageBox.Show("Ganaste"))));


        }
        private void perdio()
        {
            this.Invoke((Action)((() =>
            {
                MessageBox.Show("perdio");
                this.cancelarTodos();
                this.btnEmpezar.Show();
            })));

        }

        private async void btnEmpezar_Click(object sender, System.EventArgs e)
        {
            this.btnEmpezar.Hide();
            Task t = new Task(Comenzar);
            t.Start();
        }



        private List<int> retornaLista()
        {

            Thread.Sleep(3000);
            return new List<int>() { 1, 5, 2, 3, 8 };
        }


        private void FrmPPal_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }


        private void FrmPPal_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is NumeroLabel)
                {
                    if (GetKeyValue(e.KeyValue).ToString() == ((NumeroLabel)item).Text)
                    {
                        cancellationTokenSource[item.Name].Cancel();
                        item.Text = "";
                        item.Dispose();
                        break;
                    }

                }

            }
        }

        private void cancelarTodos()
        {

            foreach (CancellationTokenSource ct in this.cancellationTokenSource.Values)
            {
                if (ct.Token.CanBeCanceled)
                {
                    ct.Cancel();
                }

            }
        }

        private int GetKeyValue(int keyValue)
        {
            if (keyValue >= (int)Keys.D0 && keyValue <= (int)Keys.D9)
            {
                return keyValue - (int)Keys.D0;
            }
            else if (keyValue >= (int)Keys.NumPad0 && keyValue <= (int)Keys.NumPad9)
            {
                return keyValue - (int)Keys.NumPad0;
            }
            else
            {
                return -1;
            }
        }

        private void FrmPPal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelarTodos();
        }
    }
}
