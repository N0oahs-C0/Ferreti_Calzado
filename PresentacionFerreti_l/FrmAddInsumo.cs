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
    public partial class FrmAddInsumo : Form
    {
        ManejadorAlmacenInsumos Mai;
        public FrmAddInsumo()
        {
            InitializeComponent();
            Mai = new ManejadorAlmacenInsumos();
            if (FrmAlmacenInsumos.Ea.Id >0)
            {
                txtCantidad.Text = FrmAlmacenInsumos.Ea.Cantidad.ToString();
                txtCosto.Text = FrmAlmacenInsumos.Ea.Costo.ToString();
                txtNombre.Text = FrmAlmacenInsumos.Ea.Nombre.ToString();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            EAlmacenInsumo Ea = new EAlmacenInsumo(0,"",0,0,0);
            Ea.Id = FrmAlmacenInsumos.Ea.Id;
            Ea.Nombre = txtNombre.Text;
            Ea.Cantidad = int.Parse(txtCantidad.Text);
            Ea.Costo = int.Parse(txtCosto.Text);
            Ea.Cantidadxpar = int.Parse(TxtCnpp.Text);
            Mai.guardar(Ea);
        }
    }
}
