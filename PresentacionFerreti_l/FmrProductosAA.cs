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
    public partial class FmrProductosAA : Form
    {
        MProductosA ma;
        public FmrProductosAA()
        {
            InitializeComponent();
            ma = new MProductosA();
            if (FmrProductosA.entidad.Id>0)
            {
                txtcanti.Text = FmrProductosA.entidad.Cantidad.ToString();
                txtfkpedido.Text = FmrProductosA.entidad.Fkpedido.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ma.Guardar(new ProductosA(FmrProductosA.entidad.Id, int.Parse(txtcanti.Text), int.Parse(txtfkpedido.Text)));
            Close();
        }
    }
}
