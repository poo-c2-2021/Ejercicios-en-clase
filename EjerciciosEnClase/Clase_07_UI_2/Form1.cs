using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Clase_07_UI_2
{
    public partial class Form1 : Form
    {
        Guitarra guitarra;
        Cliente cliente1;
        Cliente cliente2;

        public Form1()
        {
            InitializeComponent();

            guitarra = new Guitarra("Gibson", "Les Paul", 550000);

            cliente1 = new Cliente("Pepe");
            cliente2 = new Cliente("Juana",guitarra);


        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

            this.txt_nombreCliente.Text = cliente2.Nombre;

            this.txt_info.Text = cliente2.Instrumento.Precio.ToString();




        }
    }
}
