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
            //primero
            MessageBox.Show("new");
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
            //MessageBox.Show(this.txtNombre.Text);
        }

        private void FrmHereo_Activated(object sender, EventArgs e)
        {
            //tercero
            //MessageBox.Show("activate");
        }

        private void FrmHereo_Load(object sender, EventArgs e)
        {
            //segundo
            MessageBox.Show("load");
        }

        private void FrmHereo_Paint(object sender, PaintEventArgs e)
        {
            //cuarto
            //MessageBox.Show("paint");
        }

        private void FrmHereo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se esta por cerrar
        }
    }
}
