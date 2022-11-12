using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesFerreti;
using ManejadorFerreti;

namespace PresentacionFerreti
{
    public partial class FrmAddCompraInsumos : Form
    {
        ManejadorCompraInsumo Mci;
        public FrmAddCompraInsumos()
        {
            InitializeComponent();
            Mci.ExportarInsumos(CmbInsumo);
            Mci = new ManejadorCompraInsumo();
            if (FrmCompraInsumos.Ec.Id>0)
            {
                CmbInsumo.Text = FrmCompraInsumos.FkInsumo;
                txtCantidad.Text = FrmCompraInsumos.Ec.Cantidad.ToString();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ECompraInsumo Ec = new ECompraInsumo(0,0,0);
            Ec.Id = FrmCompraInsumos.Ec.Id;
            Ec.Cantidad = int.Parse(txtCantidad.Text);
            Ec.Fkinsumo =Convert.ToInt32(CmbInsumo.SelectedValue);
            Mci.guardar(Ec);
            Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
