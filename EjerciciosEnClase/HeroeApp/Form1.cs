
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


namespace HeroeApp
{
    public partial class FrmUniverso : Form
    {

        Universo universo;
        public FrmUniverso()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            universo = (Universo)8;

        }

        private void btnNuevoHeroe_Click(object sender, EventArgs e)
        {
            FrmHereo frmHereo = new FrmHereo();

            frmHereo.SetTextBox("llegué al otro form");
            frmHereo.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmUniverso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEscenario frmEscenario = new FrmEscenario();
            frmEscenario.MdiParent = this;
            frmEscenario.Show();
            
        }

        private void FrmModal_Click(object sender, EventArgs e)
        {
            FrmEscenario frmEscenario = new FrmEscenario();
            frmEscenario.ShowDialog() ;

        }
    }
}
