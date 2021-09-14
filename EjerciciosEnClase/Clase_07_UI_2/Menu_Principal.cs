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
    public partial class Menu_Principal : Form
    {
        List<Guitarra> listaGuitarras;
        Inventario inventario;
        public Menu_Principal()
        {
            InitializeComponent();

            inventario = new Inventario();


            listaGuitarras = new List<Guitarra>() { 
             new Guitarra(EMarca.Gibson,"Les Paul",500000),
             new Guitarra(EMarca.Fender,"Telecaster",300000),
             new Guitarra(EMarca.Cort,"SG",50000)
            };

        }




        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            rtx_catalogo.Text = string.Empty;

            foreach (Guitarra item in listaGuitarras)
            {
                rtx_catalogo.Text += item.Informacion;
            }

        }


        private void btn_alta_Click(object sender, EventArgs e)
        {
            Guitarra aux;

            Alta_Instrumento frmAlta = new Alta_Instrumento();

            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                aux = frmAlta.GuitarraCreada;

                listaGuitarras.Add(aux);

                rtx_catalogo.Text += aux.Informacion;

            }
            else
            {
                MessageBox.Show("accion cancelada");
            }
        }

        private void btn_prop_Click(object sender, EventArgs e)
        {

          //  int indice = int.Parse(this.tb_numero.Text);

            this.lbl_Info.Text = inventario[this.tb_numero.Text].Informacion;





        }
    }
}
