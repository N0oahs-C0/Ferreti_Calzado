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
    public partial class FmrProductosTA : Form
    {
        MProductosT mt;
        public FmrProductosTA()
        {
            InitializeComponent();
            mt = new MProductosT();
            if (FmrProductoT.entidad.Id>0)
            {
                txtname.Text = FmrProductoT.entidad.Productos;
                txtcanti.Text = FmrProductoT.entidad.Cantidad.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mt.Guardar(new ProductosT(FmrProductoT.entidad.Id, (txtname.Text), int.Parse(txtcanti.Text)));
        }
    }
}
