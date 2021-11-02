using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegadosUI
{
    public partial class Form1 : Form
    {

        Auto auto1;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            auto1 = new Auto("Fiat 600", 10);
            
            
            this.btnAndar.Click += this.button1_Click;
            

            this.auto1.prendeLaReserva += reserva;
            this.auto1.prendeLaReserva += quiereCargar;
            this.auto1.aCaminar += Caminar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnAndar.Click -= this.button1_Click;
            try
            {
                this.auto1.recorrer(int.Parse(this.txtkm.Text));

            }
            catch (Exception ex) { }
                
            
            
            this.label2.Text = this.auto1.Litros.ToString();
            
            this.btnAndar.Click += this.button1_Click;


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.auto1.cargar();
        }

        private void reserva()
        {
            this.BackColor = Color.Yellow;
        }

        private void Caminar()
        {
            MessageBox.Show("Se quedó sin nafta");
        }

        private void quiereCargar()
        {
            if (MessageBox.Show("¿Quiere cargar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                this.auto1.cargar();
                this.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void mostrar (object sender, EventArgs e)
        {
            
        }

     
    }
}
