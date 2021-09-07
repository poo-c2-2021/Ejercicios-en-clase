
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
    }
}
