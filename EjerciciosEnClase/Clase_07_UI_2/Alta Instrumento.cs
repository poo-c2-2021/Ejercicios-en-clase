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

        public Alta_Instrumento()
        {
            InitializeComponent();
          
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            auxGuitarra = new Guitarra(EMarca.Cort, "pepe", 20000);


        }

        private void Alta_Instrumento_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Enum.GetValues(typeof(EMarca));
        }
    }
}
