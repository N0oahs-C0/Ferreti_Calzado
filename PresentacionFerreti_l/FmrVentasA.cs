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
    public partial class FmrVentasA : Form
    {
        MVentas mve;
        public FmrVentasA()
        {
            InitializeComponent();
            mve = new MVentas();
            if (FmrVentas.ventas.Id>0)
            {
                txtfkpedido.Text = FmrVentas.ventas.Fkpedido.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mve.Guardar(new Ventas(FmrVentas.ventas.Id, int.Parse(txtfkpedido.Text)));
        }
    }
}
