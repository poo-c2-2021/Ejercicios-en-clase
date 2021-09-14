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
    public partial class Alta_Instrumento : Form
    {

        Guitarra auxGuitarra;

        public Guitarra InfoGuitarra
        {
            get
            {
                return auxGuitarra;
            }
        }



        public Alta_Instrumento()
        {
            InitializeComponent();

        }
        private void Alta_Instrumento_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Enum.GetValues(typeof(EMarca));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            EMarca auxDato = (EMarca)comboBox1.SelectedItem;

            auxGuitarra = new Guitarra(auxDato, this.textBox1.Text, 20000);

            this.DialogResult = DialogResult.OK;


        }



    }
}
