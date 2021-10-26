using MensajesEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUI
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensajeria.BuscarUSuarios();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = txtNombre.Text;
            nuevoUsuario.Pass = txtPass.Text;
            nuevoUsuario.NombreUsuario = txtNombreUSuario.Text;
            Mensajeria.InsertarUsuario(nuevoUsuario);
        }
    }
}
