using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroeApp
{
    public partial class FrmEscenario : Form
    {
        public FrmEscenario()
        {
            InitializeComponent();
            
        }

        public void verFormulario()
        {
            ((FrmUniverso)this.MdiParent).Text = "";
        }
    }
}
