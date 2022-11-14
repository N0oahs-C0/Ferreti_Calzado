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

        private void tsbPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.ShowDialog();
        }

        private void TsbVentas_Click(object sender, EventArgs e)
        {
            FmrVentaas fa = new FmrVentaas();
            fa.ShowDialog();
        }

        private void TsbAlmacenInsumos_Click(object sender, EventArgs e)
        {
            FrmAlmacenInsumos frm = new FrmAlmacenInsumos();
            frm.ShowDialog();
        }

        private void tsbCompraInsumos_Click(object sender, EventArgs e)
        {
            FrmCompraInsumos frm = new FrmCompraInsumos();
            frm.ShowDialog();
        }

        private void tsbProductost_Click(object sender, EventArgs e)
        {
            FmrProductoT ft = new FmrProductoT();
            ft.ShowDialog();
        }

        private void TsbProductA_Click(object sender, EventArgs e)
        {
            FmrProductosA fa = new FmrProductosA();
            fa.ShowDialog();
        }

        private void TspSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
