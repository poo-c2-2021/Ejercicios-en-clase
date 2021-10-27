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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.NombreUsuario = txtUsuario.Text;
            user.Pass = txtPass.Text;

            Mensajeria.Loguear(user);

            if (Mensajeria.TieneUsuario())
            {
                MessageBox.Show("Bienvenido " + Mensajeria.usuarioLogueado.Nombre);
            }


        }
    }
}
