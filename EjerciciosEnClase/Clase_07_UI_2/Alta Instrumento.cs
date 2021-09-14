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

        public Guitarra GuitarraCreada // SOLO LECTURA
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
            this.cbx_marca.DataSource = Enum.GetValues(typeof(EMarca));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            EMarca auxDato = (EMarca)cbx_marca.SelectedItem;

            if (auxDato.ToString() != "" && this.txt_modelo.Text.Length != 0)
            {
                auxGuitarra = new Guitarra(auxDato, this.txt_modelo.Text, 20000);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Guitarra no creada correctamente. Verifique datos");
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
