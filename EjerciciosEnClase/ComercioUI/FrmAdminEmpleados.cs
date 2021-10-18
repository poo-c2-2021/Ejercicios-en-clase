using EntidadesComercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercioUI
{
    public partial class FrmAdminEmpleados : Form
    {

        public Persona persona;
        public FrmAdminEmpleados()
        {
            InitializeComponent();
        }

        private void FrmAdminEmpleados_Load(object sender, EventArgs e)
        {

            List<Persona> personas = new List<Persona>()
            {
                new Jefe(){Bono=444,Cuil=254513,Nombre="dasdas",Sueldo=455 },
                new Jefe(){Bono=444,Cuil=254513,Nombre="dasdas",Sueldo=455 },
                new Empleado(){Cuil=254513,Nombre="dasdas",Sueldo=455 },
                new Empleado(){Cuil=254513,Nombre="dasdas",Sueldo=455 },
                new Vendedor(){Objetivo=444,Cuil=254513,Nombre="dasdas",Sueldo=455 },
                new Vendedor(){Objetivo=444,Cuil=254513,Nombre="dasdas",Sueldo=455 },
            }
            this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          

            
            try
            {

                

                switch ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem)
                {
                    case ETipoEmpleado.Empleado:
                        this.persona = new Empleado(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text));
                        break;
                    case ETipoEmpleado.Jefe:
                        this.persona = new Jefe(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text), int.Parse(this.txtBono.Text));
                        break;
                    case ETipoEmpleado.Vendedor:
                        this.persona = new Vendedor(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text), int.Parse(this.txtObjetivo.Text));
                        break;
                }




                if (this.persona.Cuil != 0)
                    this.DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Error en el cuil");

                this.limpiar();

            }
            catch (CuilException)
            {
                MessageBox.Show("verifique el cuil");
            }
            catch (NombreException nmbreex)
            {

                MessageBox.Show(nmbreex.Message);
                
            }
            catch(Exception e)
            {

            }
            finally
            {
                this.limpiar();
            }
            this.limpiar();
        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblBono.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            this.txtBono.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            this.lblObjetivo.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
            this.txtObjetivo.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
        }
        private void limpiar()
        {
            this.limpiarControles(this.Controls);
        }

        private void limpiarControles(System.Windows.Forms.Control.ControlCollection c)
        {
            foreach (Control item in c)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is Panel)
                    this.limpiarControles(((Panel)item).Controls);

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            this.persona.Mostrar();              
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            //            FrmAumentos frmAumentos = new FrmAumentos();
            //          frmAumentos.Show();
        }

        
    }
}
