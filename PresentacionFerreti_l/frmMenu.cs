using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFerreti_l
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlmacenInsumos_Click(object sender, EventArgs e)
        {
            FrmAlmacenInsumos frm = new FrmAlmacenInsumos();
            frm.ShowDialog();
        }

        private void btnCompraInsumos_Click(object sender, EventArgs e)
        {
            FrmCompraInsumos frm = new FrmCompraInsumos();
            frm.ShowDialog();
        }
    }
}
