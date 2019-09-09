using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.PROTESTO
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCarga frmCarga = new frmCarga();
            frmCarga.Show();
        }

        private void btnProtestos_Click(object sender, EventArgs e)
        {
            frmProtestos frmProtestos = new frmProtestos();
            frmProtestos.Show();
        }
    }
}
