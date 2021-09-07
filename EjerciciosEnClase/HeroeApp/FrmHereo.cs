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

    public partial class FrmHereo : Form
    {

        Heroe heroe;

        public FrmHereo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.heroe = new Heroe(this.txtNombre.Text,
                this.cmbPoder.SelectedItem.ToString(), 
                (int)this.numNivelFuerza.Value);
            heroe.SetEsAyudante(this.chkEsAyudante.Checked);

            MessageBox.Show(heroe.HeroeToString());
        }

        public void SetTextBox(string nombre)
        {
            this.txtNombre.Text = nombre;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.txtNombre.Text);
        }
    }
}
