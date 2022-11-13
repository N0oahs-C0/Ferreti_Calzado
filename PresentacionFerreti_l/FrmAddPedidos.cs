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

namespace PresentacionFerreti_l
{
    public partial class FrmAddPedidos : Form
    {
        ManejadorPedidos Mp;
        public FrmAddPedidos()
        {
            InitializeComponent();
            Mp = new ManejadorPedidos();
            if (FrmPedidos.p.Id > 0)
            {
                TxtCantidad.Text = FrmPedidos.p.Cantidad.ToString();
                TxtCliente.Text = FrmPedidos.p.Cliente.ToString();

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Peddidos p = new Peddidos(0,"",0);
            p.Cantidad =int.Parse(TxtCantidad.Text);
            p.Cliente = TxtCliente.Text;
            p.Id = FrmPedidos.p.Id;
            Mp.guardar(p);
            Close();
        }
    }
}
