using DelegadosEntidades;
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

        private void mostrar(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Auto> autos = new List<Auto>();

            autos.Add(new Auto("Focus", 50));
            autos.Add(new Auto("Corsa", 40));
            autos.Add(new Auto("Fiesta", 50));
            autos.Add(new Auto("Camaro", 80));
            autos.Add(new Auto("Mustang", 45));
            autos.Add(new Auto("147", 21));
            autos.Add(new Auto("600", 55));
            autos.Add(new Auto("Rastrojero", 2));

            this.dataGridView1.DataSource = autos;

            autos.Sort(Auto.ordenar);


            Validadora.Validar<Auto>(autos[0],
                (a) => MessageBox.Show($"autoValido: {a.NombreAuto}"),
                (b) => MessageBox.Show($"auto inVálido: {b.NombreAuto}"));


            Validadora.Validar<Class1>(new Class1(),
                   (a) => Console.WriteLine(a.ToString()),
                   (a) => Console.WriteLine("error" + a.ToString())
               );


        }
    }
}
