using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorFerreti;
using EntidadesFerreti;

namespace PresentacionFerreti_l
{
    public partial class fmrVentasAA : Form
    {
        MVentas mv;
        public fmrVentasAA()
        {
            InitializeComponent();
            mv = new MVentas();
            //mv.ExtraerPedido(cmbfkpedido);
            if (FmrVentaas.ventas.Id > 0)
            {
                txtfkpedido.Text = FmrVentaas.ventas.Fkpedido.ToString();
                //cmbfkpedido.Text = FmrVentaas.Fkpedido.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mv.Guardar(new Ventas(FmrVentaas.ventas.Id, int.Parse(txtfkpedido.Text)));
            Close();
        }
    }
}
